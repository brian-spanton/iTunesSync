namespace foobalator.iTunesSync
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using foobalator;

    public class iTunesLibrary
    {
        private Dictionary<string, object> items = new Dictionary<string, object>();
        public Dictionary<long, iTunesTrack> tracks = new Dictionary<long, iTunesTrack>();
        public Dictionary<long, iTunesTrack> selected = new Dictionary<long, iTunesTrack>();
        public List<iTunesPlaylist> playlists = new List<iTunesPlaylist>();

        public static string DefaultLibrary;

        static iTunesLibrary()
        {
            DefaultLibrary = System.Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Music\iTunes\iTunes Music Library.xml");
        }

        public bool Parse(string libraryFile)
        {
            if (!File.Exists(libraryFile))
            {
                foobalator.Log.WriteLine(string.Format("File \"{0}\" does not exist", libraryFile));
                return false;
            }

            foobalator.Log.WriteLine(string.Format("Scanning file \"{0}\"", libraryFile));

            XmlDocument doc = new XmlDocument();
            doc.Load(libraryFile);

            XmlNode root = doc.SelectSingleNode("/plist/dict");
            items = ParseDictionary(root);

            Dictionary<string, object> rawTracks = (Dictionary<string, object>)items["Tracks"];
            foreach (var rawTrack in rawTracks)
            {
                long id = long.Parse(rawTrack.Key);
                Dictionary<string, object> fields = (Dictionary<string, object>)rawTrack.Value;

                iTunesTrack track = new iTunesTrack(this, fields);

                tracks.Add(id, track);

                if (track.selected && track.format != default(Guid) && track.path != null)
                    selected.Add(id, track);
            }

            foobalator.Log.WriteLine(string.Format("{0}/{1} tracks selected", selected.Count, tracks.Count));

            List<object> rawPlaylists = (List<object>)items["Playlists"];
            foreach (var rawPlaylist in rawPlaylists)
            {
                Dictionary<string, object> fields = (Dictionary<string, object>)rawPlaylist;

                iTunesPlaylist playlist = new iTunesPlaylist(this, fields);
                if (!playlist.visible)
                    continue;

                playlists.Add(playlist);
            }

            foobalator.Log.WriteLine(string.Format("{0} visible playlists", playlists.Count));

            return true;
        }

        enum State
        {
            Key,
            Value,
        }

        private Dictionary<string, object> ParseDictionary(XmlNode node)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            string key = null;
            State state = State.Key;

            foreach (XmlNode child in node.ChildNodes)
            {
                switch (state)
                {
                    case State.Key:
                        key = child.FirstChild.Value;
                        state = State.Value;
                        break;

                    case State.Value:
                        {
                            object value = ParseValue(child);
                            dictionary.Add(key, value);
                            state = State.Key;
                            break;
                        }
                }
            }

            return dictionary;
        }

        private object ParseValue(XmlNode value)
        {
            if (value.Name == "integer")
                return value.FirstChild == null ? null : (object)long.Parse(value.FirstChild.Value);
            else if (value.Name == "string")
                return value.FirstChild == null ? null : (object)value.FirstChild.Value;
            else if (value.Name == "date")
                return value.FirstChild == null ? null : (object)DateTime.Parse(value.FirstChild.Value);
            else if (value.Name == "true")
                return true;
            else if (value.Name == "false")
                return false;
            else if (value.Name == "dict")
                return ParseDictionary(value);
            else if (value.Name == "array")
                return ParseArray(value);
            else
                return null;
        }

        private List<object> ParseArray(XmlNode node)
        {
            List<object> list = new List<object>();

            foreach (XmlNode child in node.ChildNodes)
            {
                object value = ParseValue(child);
                list.Add(value);
            }

            return list;
        }
    }
}
