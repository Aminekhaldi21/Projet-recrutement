using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace e_E_Recrutement.Models
{
    public class initializer: DropCreateDatabaseIfModelChanges<OffreContext>
    {
        protected override void Seed(OffreContext context)
        {
            base.Seed(context);
            var offreList = new List<Offre>();
            
            
        }
    }
}