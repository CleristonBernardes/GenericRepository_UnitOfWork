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
            IEnumerable<BusinessCard> card = cardRepository.Table.ToList();
            return View(card);
        }

        // GET: Card/Details/5
        public ActionResult Details(int id)
        {
            BusinessCard card = cardRepository.GetById(id);
            return View(card);
        }

        public ActionResult Save(int id)
        {
            BusinessCard card;
            if (id == 0)
                card = new BusinessCard();
            else
                card = cardRepository.GetById(id);
            
            return View(card);
        }

        // GET: Card/Create
        [HttpPost]
        public ActionResult CreateOrEdit(BusinessCard card)
        {
            if (card.ID == 0)
            {
                card.ModifiedDate = System.DateTime.Now;
                card.AddedDate = System.DateTime.Now;
                card.AddedUser = "new user";
                card.IP = Request.UserHostAddress;
                cardRepository.Insert(card);
            }
            else
            {
                var cardEdt = cardRepository.GetById(card.ID);
                cardEdt.Name = card.Name;
                cardEdt.Email = card.Email;
                cardEdt.MobilePhone = card.MobilePhone;
                cardEdt.CompanyName = card.CompanyName;
                cardEdt.TitlePosition = card.TitlePosition;
                cardEdt.ModifiedDate = System.DateTime.Now;
                cardEdt.ModifiedUser = "edit user";
                cardEdt.IP = Request.UserHostAddress;
                cardRepository.Update(cardEdt);
            }

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
            BusinessCard card = cardRepository.GetById(id);
            cardRepository.Delete(card);
            return RedirectToAction("Index");
        }
        
    }
}
