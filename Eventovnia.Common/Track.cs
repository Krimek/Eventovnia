using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventovnia.Admin.Common
{
    public class Track
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public TimeSpan StartMusic { get; set; }
        public TimeSpan EndMusic { get; set; }
        public Uri Path { get; set; }

        public Track() { }

        public Track(Uri path)
        {
            Path = path;
        }

        public Track(string author, string title, TimeSpan length, Uri path)
        {
            Author = author;
            Title = title;
            Length = length;
            Path = path;
            StartMusic = new TimeSpan(0, 0, 0, 0);
            EndMusic = Length;
        }

        public Track(string author, string title, TimeSpan length, Uri path, TimeSpan startMusic, TimeSpan endMusic)
        {
            Author = author;
            Title = title;
            Length = length;
            Path = path;
            StartMusic = startMusic;
            EndMusic = endMusic;
        }
    }
}
