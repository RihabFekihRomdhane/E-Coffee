using ECoffee.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCoffee.web.Models
{
    public class OrderViewModel
    {
        [Display(Name = "Produit")]
        public Recipe Product { get; set; }

        [Display(Name = "Prix")]
        public float Price { get; set; }
    }
}