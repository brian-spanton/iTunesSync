namespace foobalator.iTunesSync
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class Device
    {
        internal IPortableDeviceContent content;
        internal IPortableDeviceProperties properties;

        private string id;
        private string description;
        private DeviceObject musicFolder;
        private DeviceObject playlistFolder;
        private Dictionary<string, DeviceObject> objects = new Dictionary<string, DeviceObject>();

        public DeviceObject GetObject(string id)
        {
            DeviceObject o = null;
            if (!objects.TryGetValue(id, out o))
            {
                o = new DeviceObject(this, id);
                objects.Add(id, o);
            }

            return o;
        }

        public Device(PortableDeviceManager devices, string id)
        {
            this.id = id;

            uint length = 0;
            devices.GetDeviceDescription(id, null, ref length);

            char[] bytes = new char[length];
            devices.GetDeviceDescription(id, bytes, ref length);
            description = new string(bytes, 0, (int)length - 1);

            foobalator.Log.WriteLine(string.Format("Discovered {0}", description));

            PortableDeviceValues values = new PortableDeviceValues();
            values.SetUnsignedIntegerValue(Constants.WPD_CLIENT_DESIRED_ACCESS, Constants.GENERIC_READ | Constants.GENERIC_WRITE);

            PortableDevice device = new PortableDevice();
            device.Open(id, values);
            device.Content(out content);
            content.Properties(out properties);

            DeviceObject root = new DeviceObject(this, "DEVICE");

            DeviceObject phoneFolder = root.GetChildByName("Phone");
            if (phoneFolder == null)
                return;

            musicFolder = phoneFolder.GetChildByName("Music");
            if (musicFolder == null)
                return;

            playlistFolder = musicFolder.GetChildByName("Playlist");
            if (playlistFolder == null)
                return;
        }

        public void Sync(iTunesLibrary library)
        {
            SyncTracks(library);
            SyncPlaylists(library);
        }

        public void SyncTracks(iTunesLibrary library)
        {
            if (musicFolder == null)
            {
                foobalator.Log.WriteLine("Music folder could not be found");
                return;
            }

            foreach (var iTunesTrack in library.selected.Values)
            {
                try
                {
                    if (iTunesTrack.path == null)
                    {
                        foobalator.Log.WriteLine(string.Format("{0}/{1}/{2} has no source.  tracktype: {3}", iTunesTrack.artist, iTunesTrack.album, iTunesTrack.name, iTunesTrack.trackType));
                        continue;
                    }

                    if (!File.Exists(iTunesTrack.path))
                    {
                        foobalator.Log.WriteLine(string.Format("file not found: \"{0}\"", iTunesTrack.path));
                        continue;
                    }

                    if (iTunesTrack.format == default(Guid))
                    {
                        foobalator.Log.WriteLine(string.Format("unsupported file type: \"{0}\"", iTunesTrack.path));
                        continue;
                    }

                    DeviceObject artistFolder = musicFolder.GetChildByName(iTunesTrack.artistFolder);
                    if (artistFolder == null)
                    {
                        PortableDeviceValues values = new PortableDeviceValues();
                        values.SetStringValue(Constants.WPD_OBJECT_PARENT_ID, musicFolder.id);
                        values.SetStringValue(Constants.WPD_OBJECT_NAME, iTunesTrack.artistFolder);
                        values.SetStringValue(Constants.WPD_OBJECT_ORIGINAL_FILE_NAME, iTunesTrack.artistFolder);
                        values.SetGuidValue(Constants.WPD_OBJECT_CONTENT_TYPE, Constants.WPD_CONTENT_TYPE_FOLDER);
                        values.SetGuidValue(Constants.WPD_OBJECT_FORMAT, Constants.WPD_OBJECT_FORMAT_PROPERTIES_ONLY);

                        string artistFolderDeviceId = null;
                        content.CreateObjectWithPropertiesOnly(values, ref artistFolderDeviceId);
                        artistFolder = GetObject(artistFolderDeviceId);
                    }

                    DeviceObject albumFolder = artistFolder.GetChildByName(iTunesTrack.albumFolder);
                    if (albumFolder == null)
                    {
                        PortableDeviceValues values = new PortableDeviceValues();
                        values.SetStringValue(Constants.WPD_OBJECT_PARENT_ID, artistFolder.id);
                        values.SetStringValue(Constants.WPD_OBJECT_NAME, iTunesTrack.albumFolder);
                        values.SetStringValue(Constants.WPD_OBJECT_ORIGINAL_FILE_NAME, iTunesTrack.albumFolder);
                        values.SetGuidValue(Constants.WPD_OBJECT_CONTENT_TYPE, Constants.WPD_CONTENT_TYPE_FOLDER);
                        values.SetGuidValue(Constants.WPD_OBJECT_FORMAT, Constants.WPD_OBJECT_FORMAT_PROPERTIES_ONLY);

                        string albumFolderDeviceId = null;
                        content.CreateObjectWithPropertiesOnly(values, ref albumFolderDeviceId);
                        albumFolder = GetObject(albumFolderDeviceId);
                    }

                    DeviceObject deviceObject = albumFolder.GetChildByOriginalFilename(iTunesTrack.filename);
                    if (deviceObject == null)
                    {
                        foobalator.Log.WriteLine(iTunesTrack.ToString());

                        PortableDeviceValues values = new PortableDeviceValues();
                        values.SetStringValue(Constants.WPD_OBJECT_PARENT_ID, albumFolder.id);
                        values.SetStringValue(Constants.WPD_OBJECT_NAME, iTunesTrack.filename);
                        values.SetGuidValue(Constants.WPD_OBJECT_FORMAT, iTunesTrack.format);
                        values.SetGuidValue(Constants.WPD_OBJECT_CONTENT_TYPE, Constants.WPD_CONTENT_TYPE_AUDIO);
                        values.SetStringValue(Constants.WPD_OBJECT_ORIGINAL_FILE_NAME, iTunesTrack.filename);
                        values.SetStringValue(Constants.WPD_MEDIA_ARTIST, iTunesTrack.artist);
                        values.SetStringValue(Constants.WPD_MEDIA_ALBUM_ARTIST, iTunesTrack.albumArtist);
                        values.SetStringValue(Constants.WPD_MUSIC_ALBUM, iTunesTrack.album);
                        values.SetUnsignedIntegerValue(Constants.WPD_MUSIC_TRACK, iTunesTrack.number);

                        System.Runtime.InteropServices.ComTypes.IStream deviceData;
                        uint writeSize = 0x10000;
                        string cookie = "";

                        content.CreateObjectWithPropertiesAndData(values, out deviceData, ref writeSize, ref cookie);

                        try
                        {
                            using (FileStream sourceData = File.OpenRead(iTunesTrack.path))
                            {
                                while (true)
                                {
                                    byte[] bytes = new byte[writeSize];

                                    int length = sourceData.Read(bytes, 0, (int)bytes.Length);
                                    if (length <= 0)
                                        break;

                                    deviceData.Write(bytes, length, new IntPtr());
                                }
                            }

                            deviceData.Commit(0);
                        }
                        catch
                        {
                            deviceData.Revert();
                            content.Cancel();

                            throw;
                        }

                        deviceObject = albumFolder.GetChildByOriginalFilename(iTunesTrack.filename, true);
                    }

                    iTunesTrack.deviceObject = deviceObject;
                }
                catch (Exception e)
                {
                    foobalator.Log.Write(iTunesTrack.ToString(), e);
                }
            }
        }

        public void SyncPlaylists(iTunesLibrary library)
        {
            if (playlistFolder == null)
            {
                foobalator.Log.WriteLine("Playlists folder could not be found");
                return;
            }

            foreach (var playlist in library.playlists)
            {
                try
                {
                    DeviceObject deviceObject = playlistFolder.GetChildByName(playlist.name);
                    if (deviceObject == null)
                    {
                        foobalator.Log.WriteLine(playlist.ToString());

                        var references = new PortableDevicePropVariantCollection();
                        foreach (var track in playlist.Tracks)
                        {
                            if (track.deviceObject == null)
                                continue;

                            //var item = Constants.ToPropVariant(track.deviceObject.id);
                            //var item = new System.Runtime.InteropServices.VariantWrapper(track.deviceObject.id);
                            //references.Add(item);
                        }

                        uint count = 0;
                        references.GetCount(ref count);

                        var values = new PortableDeviceValues();
                        values.SetStringValue(Constants.WPD_OBJECT_PARENT_ID, playlistFolder.id);
                        values.SetStringValue(Constants.WPD_OBJECT_NAME, playlist.name);
                        //values.SetStringValue(Constants.WPD_OBJECT_ORIGINAL_FILE_NAME, playlist.name);
                        values.SetGuidValue(Constants.WPD_OBJECT_CONTENT_TYPE, Constants.WPD_CONTENT_TYPE_PLAYLIST);
                        values.SetUnsignedIntegerValue(Constants.WPD_OBJECT_SIZE, count);
                        //values.SetGuidValue(Constants.WPD_OBJECT_FORMAT, Constants.WPD_OBJECT_FORMAT_WPLPLAYLIST);
                        //values.SetGuidValue(Constants.WPD_OBJECT_FORMAT, Constants.WPD_OBJECT_FORMAT_PROPERTIES_ONLY);
                        //values.SetIPortableDevicePropVariantCollectionValue(Constants.WPD_OBJECT_REFERENCES, references);

                        string playlistDeviceId = null;
                        content.CreateObjectWithPropertiesOnly(values, ref playlistDeviceId);
                        deviceObject = playlistFolder.GetChildByName(playlist.name, true);
                    }

                    playlist.deviceObject = deviceObject;
                }
                catch (Exception e)
                {
                    foobalator.Log.Write(playlist.ToString(), e);
                }
            }
        }
    }
}
