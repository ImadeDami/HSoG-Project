using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSoG.Portal.Core.Data.Music
{
    public partial class Song
    {
        public Song()
        {
            Schedules = new HashSet<SongSchedule>();
            Tags = new HashSet<SongTag>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public string Album { get; set; }
        public string Lyrics { get; set; }
        public int GenreId { get; set; }
        public string OriginalLink { get; set; }
        public string RecordingLink { get; set; }
        public string Url { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<SongSchedule> Schedules { get; set; }
        public virtual ICollection<SongTag> Tags { get; set; }
    }
}
