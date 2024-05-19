using e_E_Recrutement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace e_E_Recrutement.Controllers
{
    public class OffresController : Controller
    {
        OffreContext offreContext=new OffreContext();
        // GET: Offres
        public ActionResult listOffre()
        {
            return View(offreContext.Offres.ToList());
        }
        
        public ActionResult ajouterOffre()
        {
            Offre O = new Offre();

            return View("ajouterOffre", O);

        }
        [HttpPost]
        public ActionResult ajouterOffre(Offre O)
        {
            if (ModelState.IsValid)
            {
                offreContext.Offres.Add(O);
                offreContext.SaveChanges();
                return RedirectToAction("offreList");

            }
            else return View("AjouterOffre", O);

        }
        public ActionResult AfficherOffre(int Id)
        {
            Offre O = new Offre();
            O = offreContext.Offres.Find(Id);
            if (O != null)
                return View("AfficherOffre", O);
            else return HttpNotFound();
        }
        public ActionResult ListeSuppression()
        {
            return View("ListeSuppression", offreContext.Offres.ToList());
        }
    }
}