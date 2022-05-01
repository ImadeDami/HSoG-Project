using System;
using System.Collections.Generic;

namespace HSoG.Portal.Core.Data.Music
{
    public partial class Tag
    {
        public Tag()
        {
            Tags = new HashSet<SongTag>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SongTag> Tags { get; set; }
    }
}