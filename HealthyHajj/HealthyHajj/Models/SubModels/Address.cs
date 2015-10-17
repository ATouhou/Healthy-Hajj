using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace HealthyHajj.Models.SubModels
{
    public class Address
    {
        [DisplayName("Street")]
        public string Street { get; set; }

        [DisplayName("Street 2")]
        public string Street2 { get; set; }

        [DisplayName("Street 3")]
        public string Street3 { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("Region")]
        public string Region { get; set; }

        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        [DisplayName("Country")]
        public string Country { get; set; }
    }
}