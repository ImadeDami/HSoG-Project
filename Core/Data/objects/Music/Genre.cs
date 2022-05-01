using System.Collections.Generic;

namespace HSoG.Portal.Core.Data.Music
{
    public partial class Genre
    {
        public Genre() => Songs = new HashSet<Song>();

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
