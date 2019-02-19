using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventovnia.Admin.Common
{
    public class Playlist
    {
        public string Title { get; private set; }
        public TimeSpan PlaylistLength { get; private set; }

        public List<Track> Tracks
        {
            get => Tracks;
            set => PlaylistLength = CountLengthOfPlaylist();
        }

        public Playlist()
        {
            Title = "New playlist";
            Tracks = new List<Track>();
        }

        public Playlist(string title)
        {
            Title = title;
            Tracks = new List<Track>();
        }

        public Playlist(string title, params Track[] tracks)
        {
            Title = title;
            Tracks = new List<Track>(tracks);
        }

        private TimeSpan CountLengthOfPlaylist()
        {
            int seconds = Tracks.Sum(x => x.Length.Seconds);
            int minutes = Tracks.Sum(x => x.Length.Minutes);
            int hours = Tracks.Sum(x => x.Length.Hours);
            return new TimeSpan(hours, minutes, seconds);
        }

        public void AddTracks(params Track[] tracks)
        {
            Tracks.AddRange(tracks);
        }

        public void ReplaceTrack(Track track, int newPosition)
        {
            Tracks.Remove(track);
            Tracks.Insert(newPosition, track);
        }

        public void RemoveTracks(string author)
        {
            foreach (Track track in Tracks)
            {
                if (track.Author == author)
                {
                    Tracks.Remove(track);
                    break;
                }
            }
        }

        public void RemoveTrack(string title)
        {
            foreach (Track track in Tracks)
            {
                if (track.Title == title)
                {
                    Tracks.Remove(track);
                    break;
                }
            }
        }

        public void RemoveTracks(params string[] titles)
        {
            foreach (Track track in Tracks)
            {
                if (titles.Any(x => x == track.Title))
                {
                    Tracks.Remove(track);
                }
            }
        }
    }
}
