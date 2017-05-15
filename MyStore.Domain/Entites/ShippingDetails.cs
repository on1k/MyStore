using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.Entites
{
   public class ShippingDetails
    {
        [Required(ErrorMessage ="Please, enter the name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter the adress")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Enter the city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter the state")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Enter the country")]
        public string Country { get; set; }
        public bool GiftWarp { get; set; }
    }
}
