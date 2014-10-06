using System;
using System.IO;
using System.Collections.Generic;

namespace foobalator.iTunesSync
{
    class Program
    {
        static void Main(string[] args)
        {
            string libraryFile = args.Length > 0 ? args[0] : iTunesLibrary.DefaultLibrary;

            iTunesLibrary library = new iTunesLibrary();
            bool exists = library.Parse(libraryFile);
            if (!exists)
                return;

            if (args.Length > 1)
            {
                string destDir = args[1];

                foreach (var playlist in library.playlists)
                {
                    if (playlist.Tracks.Count > 200)
                        continue;

                    CopyTracks(playlist.Tracks, destDir);
                }
            }
            else
            {
                string[] deviceIDs = new string[1];
                uint count = (uint)deviceIDs.Length;

                PortableDeviceManager devices = new PortableDeviceManager();
                devices.GetDevices(deviceIDs, ref count);
                if (count == 0)
                {
                    foobalator.Log.WriteLine("No device connected");
                    return;
                }

                Device device = new Device(devices, deviceIDs[0]);
                device.Sync(library);
            }
        }

        static void CopyTracks(IList<iTunesTrack> tracks, string destDir)
        {
            foreach (var iTunesTrack in tracks)
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

                    string dest = Path.Combine(destDir, iTunesTrack.artistFolder);
                    dest = Path.Combine(dest, iTunesTrack.albumFolder);
                    if (!Directory.Exists(dest))
                        Directory.CreateDirectory(dest);

                    dest = Path.Combine(dest, iTunesTrack.filename);
                    if (!File.Exists(dest))
                        System.IO.File.Copy(iTunesTrack.path, dest);
                }
                catch (Exception e)
                {
                    foobalator.Log.Write(iTunesTrack.ToString(), e);
                }
            }
        }
    }
}
