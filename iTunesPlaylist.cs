namespace foobalator.iTunesSync
{
    using System.Collections.Generic;
    using System.Linq;

    public class iTunesPlaylist
    {
        public string name;
        public bool visible;
        public DeviceObject deviceObject;

        private iTunesLibrary library;
        private Dictionary<string, object> fields;

        private bool tracksInitialized = false;
        private List<iTunesTrack> tracks = new List<iTunesTrack>();

        public IList<iTunesTrack> Tracks
        {
            get
            {
                if (!tracksInitialized)
                {
                    List<object> rawItems = fields.Get<List<object>>("Playlist Items");
                    if (rawItems != null)
                    {
                        foreach (var rawItem in rawItems)
                        {
                            Dictionary<string, object> itemFields = (Dictionary<string, object>)rawItem;
                            long trackId = itemFields.Get<long>("Track ID");
                            iTunesTrack track = library.tracks[trackId];
                            tracks.Add(track);
                        }
                    }

                    tracksInitialized = true;
                }

                return tracks.AsReadOnly();
            }
        }

        public iTunesPlaylist(iTunesLibrary library, Dictionary<string, object> fields)
        {
            this.library = library;
            this.fields = fields;
            this.name = fields.Get<string>("Name");

            bool? visible = fields.Get<bool?>("Visible");
            this.visible = visible.HasValue ? visible.Value : true;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
