using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSoG.Portal.Core.Data.Membership
{
    public partial class NextOfKin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        [MaxLength(50)]
        public string OtherNames { get; set; }

        [MaxLength(6)]
        public Gender Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        [MaxLength(11)]
        public string MobileNo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        [MaxLength(120)]
        public string EmailAddress { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        [MaxLength(15)]
        public string Relationship { get; set; }

        [MaxLength(250)]
        public string HomeAddress { get; set; }

        [MaxLength(250)]
        public string OfficeAddress { get; set; }

        public virtual Member Member { get; set; }
    }
}
