using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;

namespace HSoG.Portal.Data
{
    public partial class User
    {
        public string Initial => FullName.ToCharArray().First().ToString().ToUpper();
        public string LastName => FullName.Split(' ').Last();
        public string FirstName => FullName.Replace(LastName, "").Trim();
        public MailAddress MailAddress => new(Email, FullName);
    }
}
