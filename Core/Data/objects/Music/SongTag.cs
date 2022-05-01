using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSoG.Portal.Core.Data.Music
{
    public partial class SongTag
    {
        public int SongId { get; set; }
        public int TagId { get; set; }

        public virtual Song Song { get; set; }
        public virtual Tag Tag { get; set; }
    }
}