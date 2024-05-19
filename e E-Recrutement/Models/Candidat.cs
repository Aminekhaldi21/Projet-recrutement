using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_E_Recrutement.Models
{
    public class Candidat
    {
        [Key]
        public int id_condidat { get; set; }
        public string nom { get; set; }
        public string prénom {  get; set; }
        public string titre { get; set; }
        public string diplome { get; set; }
        public int nombre_année_experience { get; set; }
        

    }
}