using MyStore.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}