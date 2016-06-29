using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessCardCore.Models;
using BusinessCardData;

namespace BusinessCardWeb.Controllers
{
    //[Authorize]
    public class CardController : Controller
    {

        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<BusinessCard> cardRepository;
        
        public CardController()
        {
            cardRepository = unitOfWork.Repository<BusinessCard>();
        }

        // GET: Card
        public ActionResult Index()
        {
            return View();
        }

        // GET: Card/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Card/Create
        [HttpPost]
        public ActionResult Create(BusinessCard card)
        {
            card.ModifiedDate = System.DateTime.Now;
            card.AddedDate = System.DateTime.Now;
            card.AddedUser = "com";
            card.IP = Request.UserHostAddress;
            cardRepository.Insert(card);

            return RedirectToAction("Index");
        }

        // GET: Card/Edit/
        [HttpPost]
        public ActionResult Edit(BusinessCard card)
        {
            return View();
        }


        // GET: Card/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        
    }
}
