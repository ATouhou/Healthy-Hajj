using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyHajj.Models.SubModels
{
    public class MedicalInformation
    {
        public Enum.Gender Gender { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }
    }
}