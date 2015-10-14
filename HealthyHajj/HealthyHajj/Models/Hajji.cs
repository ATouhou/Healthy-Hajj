using HealthyHajj.Models.SubModels;
using System;
using System.Collections.Generic;
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

        public int Id { get; set; }

        public string BraceletId { get; set; }

        public string FirstName { get; set;  }

        public string LastName { get; set; }

        public string DoctorName { get; set; }

        public virtual Address HajjiAddress { get; set; }

        public virtual Address DoctorAddress { get; set; }

        public virtual ContactInformation HajjiContact { get; set;  }

        public virtual ContactInformation DoctorContact { get; set; }

        public virtual MedicalInformation HajjiMedicalInformation { get; set; }
    }
}