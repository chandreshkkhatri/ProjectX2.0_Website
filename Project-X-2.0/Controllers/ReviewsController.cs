﻿using Project_X_2._0.Entities;
using Project_X_2._0.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_X_2._0.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ReviewsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserTripDetailsRepository _userTripDetailsRepository;

        public ReviewsController(IUnitOfWork unitOfWork, IUserTripDetailsRepository userTripDetailsRepository)
        {
            _unitOfWork = unitOfWork;
            _userTripDetailsRepository = userTripDetailsRepository;
        }


        [AllowAnonymous]
        // GET: Reviews
        public ActionResult Index()
        {
            //if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var reviews = _userTripDetailsRepository.GetAll();
            //if (reviews == null)
            {
                //return HttpNotFound();
            }
            return View();
        }

        [AllowAnonymous]
        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            _unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}
