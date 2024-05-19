using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_E_Recrutement.Models
{
    public class Offre
    {
        [Key]
        public int Id { get; set; }
        public int id_recrutement { get; set; }
        public string contrat { get; set; }
        public string secteur { get; set; }
        public string profil { get; set; }
        public string poste { get; set; }
        public int remuneration{ get; set; }


    }
}