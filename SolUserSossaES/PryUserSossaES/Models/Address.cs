using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PryUserSossaES.Models
{
    public class Address
    {
        [Key]
        [Required]
        public string street { get; set; }
        [Required]
        public string suite { get; set; }
        [Required]
        public string city { get; set; }
        public Geo geo { get; set; }
    }
}