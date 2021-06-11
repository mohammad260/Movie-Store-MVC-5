using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movie_Store_MVC_5.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string  Name { get; set; }

        [Display(Name="Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name="Membership Type")]
        public MembershipType MembershipType { get; set; }

        [Required(ErrorMessage = "Please select membership type")]
        public byte MembershipTypeId { get; set; }
    }
}