using System;

namespace Amajohn.Models
{
    public class Track
    {
        public int TrackId { get; set; }
		public string Title { set; get; }
		public string Composer { get; set; }
		public TimeSpan Length { get; set; }

        public Track(string title, TimeSpan length) {
            Title = title;
            Length = length;
        }

        public Track() {}

        public Track(string title, TimeSpan length, string composer) {
            Title = title;
            Length = length;
            Composer = composer;
        }
    }
}