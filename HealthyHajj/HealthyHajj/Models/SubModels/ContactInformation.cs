using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace HealthyHajj.Models.SubModels
{
    public class ContactInformation
    {
        [DisplayName("Primary Phone")]
        public string PrimaryPhone { get; set; }

        [DisplayName("Work Phone")]
        public string WorkPhone { get; set; }

        [DisplayName("Cellular Phone")]
        public string CellularPhone { get; set; }

        [DisplayName("Fax Number")]
        public string FaxNumber { get; set; }

        [DisplayName("Email Address")]
        public string PrimaryEmail { get; set; }
        
        [DisplayName("Alternate Email Address")]
        public string SecondaryEmail { get; set; }
    }
}