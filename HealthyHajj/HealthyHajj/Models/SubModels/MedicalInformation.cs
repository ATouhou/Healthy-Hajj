using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace HealthyHajj.Models.SubModels
{
    public class MedicalInformation
    {
        [DisplayName("Gender")]
        public Enum.Gender Gender { get; set; }

        [DisplayName("Height")]
        public int Height { get; set; }

        [DisplayName("Weight")]
        public int Weight { get; set; }
    }
}