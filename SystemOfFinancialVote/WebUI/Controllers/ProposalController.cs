using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Abstract;
using Model.Concrete;
using Model.Entities;

namespace WebUI.Controllers
{
    public class ProposalController : Controller
    {
        private ISuperRepository _repository;

        public ProposalController(ISuperRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(_repository.Proposals.Get());
        }

        public ActionResult Details(int id)
        {
            return View(_repository.Proposals.GetByID(id));
        }

        public ActionResult Edit(int id)
        {
            return View(_repository.Proposals.GetByID(id));
        }

        [HttpPost]
        public ActionResult Edit(Proposal prop)
        {
            _repository.Proposals.Update(prop);
            _repository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View("Create",new Proposal());
        }

        [HttpPost]
        public ActionResult Create(Proposal proposal)
        {
            _repository.Proposals.Insert(proposal);
            _repository.Save();
            return RedirectToAction("Details", new {proposalId = proposal.Id});
        }

        protected override void Dispose(bool disposing)
        {
            _repository.Dispose();
            base.Dispose(disposing);
        }
    }
}
