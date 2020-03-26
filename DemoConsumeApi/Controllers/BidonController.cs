using DemoConsumeApi.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoConsumeApi.Controllers
{
    public class BidonController : Controller
    {
        IBidonRepository _repository;

        public BidonController()
        {
            _repository = new BidonRepository();
        }
        // GET: Bidon
        public ActionResult Index()
        {
            IEnumerable<Bidon> bidons = _repository.Get();

            return View(bidons);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateBidonForm form)
        {

            if(ModelState.IsValid)
            {
                _repository.Post(new Bidon() { Value = form.Value });
            }
            return View();
        }
    }
}