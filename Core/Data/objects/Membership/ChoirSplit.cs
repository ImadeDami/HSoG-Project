using System.Collections.Generic;

namespace HSoG.Portal.Core.Data.Membership
{
    public partial class ChoirSplit
    {
        public ChoirSplit() => Members = new HashSet<Member>();

        public int Id { get; set; }
        public string Description { get; set; }
        public int CenterId { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
