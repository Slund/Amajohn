using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amajohn.Models
{
    // Instructs EF to TBT pattern
    [Table("MusicCD")]
    public class MusicCD : Product
    {
        private List<Track> tracks = new List<Track>();

		public string Artist { set; get; }
        public string Label { get; set; }
        public short Released { get; set; }
		virtual public List<Track> Tracks { //
            get { return tracks; }
            set { tracks = value; }
        }

        public void AddTrack(Track track) {
			tracks.Add(track);
		}

        public MusicCD() {}

        public MusicCD(string artist, string title, decimal price, short released) : base (title, price) 
        {
            Artist = artist;
            Released = released;
        }

        public TimeSpan GetPlayingTime()
        {
            TimeSpan playingTime = new TimeSpan(0, 0, 0);

            foreach (Track track in Tracks)
            {
                playingTime += track.Length;
            }
            return playingTime;
        }
    }
}