using HSoG.Portal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSoG.Portal.Core.Data.Membership
{
    public class Member
    {
        public Member()
        {
        }

        public int Id { get; set; }

        public string Code { get; set; }
        //public string LastName { get; set; }
        //public string OtherNames { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public Maritals MaritalStatus { get; set; }
        public string HomeAddress { get; set; }
        public string OfficeAddress { get; set; }
        public string Nationality { get; set; }
        public DateTime? Wedding { get; set; }
        public int OccupationId { get; set; }
        public string Nickname { get; set; }

        public int ChoirId { get; set; }
        public int AvailabilityId { get; set; }
        public string Remarks { get; set; }
        public int StateOfOriginId { get; set; }
        public string Lga { get; set; }
        public string Photo { get; set; }
        public string RobeNo { get; set; }
        public int PartId { get; set; }
        public DateTime JoinedOn { get; set; }
        public int? PostId { get; set; }
        public string HomeTown { get; set; }

        public int GroupId { get; set; }

        public int? AcademyId { get; set; }
        public DateTime? LastUpdated { get; set; }

        #region parent tables
        public virtual ChoirSplit ChoirSplit { get; set; }
        public virtual Team Team { get; set; }
        public virtual Occupation Occupation { get; set; }
        public virtual ChoirPart Part { get; set; }
        public virtual State StateOfOrigin { get; set; }
        #endregion

        #region One to One relationship
        public virtual NextOfKin NextOfKin { get; set; }
        #endregion

        public virtual User User { get; set; }
    }
}
