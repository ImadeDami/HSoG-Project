using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HSoG.Portal.Core.Data.Membership
{
    public partial class State
    {
        public State() => Members = new HashSet<Member>();

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
