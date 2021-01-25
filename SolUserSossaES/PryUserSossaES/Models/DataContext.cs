using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PryUserSossaES.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PryUserSossaES.Models.Persona> Personas { get; set; }

        public System.Data.Entity.DbSet<PryUserSossaES.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<PryUserSossaES.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<PryUserSossaES.Models.Geo> Geos { get; set; }
    }
}