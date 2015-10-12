using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyHajj.Models.SubModels
{
    public class ContactInformation
    {
        public string PrimaryPhone { get; set; }

        public string CellularPhone { get; set; }

        public string FaxNumber { get; set; }

        public string PrimaryEmail { get; set; }

        public string SecondaryEmail { get; set; }
    }
}