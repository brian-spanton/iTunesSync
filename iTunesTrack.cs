namespace foobalator.iTunesSync
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class iTunesTrack
    {
        public string path;
        public string trackType;
        public Guid format;

        public string albumArtist;
        public string album;
        public uint number;
        public string name;
        public string artist;

        public string artistFolder;
        public string albumFolder;
        public string filename;

        public DeviceObject deviceObject;
        public bool selected;

        private iTunesLibrary library;
        private Dictionary<string, object> fields;

        public iTunesTrack(iTunesLibrary library, Dictionary<string, object> fields)
        {
            this.library = library;
            this.fields = fields;

            trackType = fields.Get<string>("Track Type");
            selected = !fields.Get<bool>("Disabled");
            album = fields.Get<string>("Album");
            name = fields.Get<string>("Name");
            albumArtist = fields.Get<string>("Album Artist");
            artist = fields.Get<string>("Artist");

            path = fields.Get<string>("Location");
            if (path != null)
            {
                path = path.Substring(@"file://localhost".Length);
                path = path.Replace('/', '\\');
                path = Uri.UnescapeDataString(path);

                string folder = Path.GetDirectoryName(path);
                artistFolder = Path.GetFileName(Path.GetDirectoryName(folder));
                albumFolder = Path.GetFileName(folder);
                filename = Path.GetFileName(path);

                string extension = Path.GetExtension(filename);
                if (extension.Equals(".m4a", StringComparison.OrdinalIgnoreCase))
                    format = Constants.WPD_OBJECT_FORMAT_M4A;
                else if (extension.Equals(".mp3", StringComparison.OrdinalIgnoreCase))
                    format = Constants.WPD_OBJECT_FORMAT_MP3;
            }

        }

        public override string ToString()
        {
            return string.Format("\"{0}/{1}/{2}\"", artistFolder, albumFolder, filename);
        }
    }
}
