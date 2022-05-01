using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HSoG.Portal.Core.Data.Membership
{
    public partial class Team
    {
        public Team() => Members = new HashSet<Member>();

        public int Id { get; set; }
        public string Description { get; set; }
        public int? LeaderId { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
