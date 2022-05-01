using System;

namespace HSoG.Portal.Core.Data.Music
{
    public class SongSchedule
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public DateTime Date { get; set; }
        public ScheduleType Type { get; set; }

        public virtual Song Song { get; set; }
    }
}
