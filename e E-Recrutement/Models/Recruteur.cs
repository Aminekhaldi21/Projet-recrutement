using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_E_Recrutement.Models
{
    public class Recruteur
    {
        [Key]
        public int id_recruteur { get; set; }
        public string nom { get; set; }
        public string Telephone { get; set; }
        public EmailAddressAttribute EmailAddress { get; set; }

    }
}