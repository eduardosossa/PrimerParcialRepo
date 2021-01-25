using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PryUserSossaES.Models
{
    public class Persona
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public Address address { get; set; }
        [Required]
        public string phone { get; set; }
        public Company company { get; set; }
    }
}