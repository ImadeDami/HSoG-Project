using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HSoG.Portal.Data
{
    #region identity
    public partial class User : IdentityUser<int>
    {
        public User()
        {
        }

        public string FullName { get; set; }
        public bool AllowGroup { get; set; }
    }
    public partial class Role : IdentityRole<int>
    {
        //public virtual ICollection<UserRole> UserRoles { get; set; }
    }
    public partial class UserRole : IdentityUserRole<int>
    {
    }
    #endregion
}