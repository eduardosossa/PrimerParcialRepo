using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PryUserSossaES.Models
{
    public class Geo
    {
        [Key]
        [Required]
        public string lat { get; set; }
        [Required]
        public string lng { get; set; }
    }
}