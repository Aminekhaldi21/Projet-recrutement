using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace e_E_Recrutement.Models
{
    public class OffreContext : DbContext
    {
        public OffreContext() : base("name=OffreDb") { }
        public DbSet<Offre> Offres { get; set; }




    }
}   

    