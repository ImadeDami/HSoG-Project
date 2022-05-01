using System;
using System.Collections.Generic;

namespace HSoG.Portal.Core.Data.Membership
{
    public partial class Occupation
    {
        public Occupation() => Members = new HashSet<Member>();

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
