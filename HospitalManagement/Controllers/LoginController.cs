using HospitalManagement.DBContext;
using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagement.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(UserModel userObj)
        {

            using (HospitalManagementEntities db=new HospitalManagementEntities())
            {
                var obj = db.UserTbs.Where(a => a.UserName == userObj.UserName && a.Password == userObj.Password).FirstOrDefault();
                if (obj != null)
                {
                    Session["UserID"] = obj.UserId.ToString();
                    Session["UserName"] = obj.UserName.ToString();
                    Session["Password"] = obj.Password.ToString();
                    return RedirectToAction("Dashboard");


                }
                return View(userObj);

            }

        }


        public ActionResult Dashboard()
        {
            if (Session["UserName"] != null && Session["Password"] != null)
            {
                return RedirectToAction("Index", "Home");


            }
            else
            {
                return RedirectToAction("Login");

            }


        }


        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
    }
}
