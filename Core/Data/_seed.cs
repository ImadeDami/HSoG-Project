using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HSoG.Portal.Data
{
    public partial class Seed
    {
        public static string Data =>
        @"-- insert data
        GO";
    }
}