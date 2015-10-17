using HealthyHajj.Models.SubModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyHajj.Models
{
    public class Hajji
    {
        public Hajji()
        {
            BraceletId = string.Empty;
        }

        [Key]
        public int Id { get; set; }

        public string BraceletId { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set;  }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Primary Doctor Name")]
        public string DoctorName { get; set; }

        [DisplayName("Your Mailing Address")]
        public virtual Address HajjiAddress { get; set; }

        [DisplayName("Your Contact Information")]
        public virtual ContactInformation HajjiContact { get; set;  }

        [DisplayName("Primary Physician Contact")]
        public virtual ContactInformation DoctorContact { get; set; }

        [DisplayName("Primary Physician Address")]
        public virtual Address DoctorAddress { get; set; }

        [DisplayName("Hajji Basic Medical")]
        public virtual MedicalInformation HajjiMedicalInformation { get; set; }
    }
}