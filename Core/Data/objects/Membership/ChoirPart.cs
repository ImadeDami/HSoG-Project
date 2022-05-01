using System;
using System.Collections.Generic;

namespace HSoG.Portal.Core.Data.Membership
{
    public partial class ChoirPart
    {
        public ChoirPart() => Members = new HashSet<Member>();

        public int Id { get; set; }
        public string Part { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
