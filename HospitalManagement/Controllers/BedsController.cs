using HospitalManagement.DBContext;
using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagement.Controllers
{
    public class BedsController : Controller
    {
        // GET: Beds
        public ActionResult Index()
        {
            using (HospitalManagementEntities db = new HospitalManagementEntities())
            {
                CurrentBedModel currentBedModel = new CurrentBedModel();
                ViewData["SubCatagoryList"] = db.SubCategoryTbs.ToList();
                ViewData["CatagoryList"] = db.CategoryTbs.ToList();
                ViewData["BedTypeList"] = db.BedTypesTbs.ToList();
                return View(currentBedModel);
            }

                
        }
        public ActionResult ViewBeds()
        {
            using (HospitalManagementEntities db = new HospitalManagementEntities())
            {
                CurrentBedModel currentBedModel = new CurrentBedModel();
                var Query= db.CurrentBedTbs.ToList();
                List<CurrentBedModel> newList = new List<CurrentBedModel>();
                foreach (var q in Query)
                {
                    newList.Add(new CurrentBedModel
                    {

                        Opex = q.Opex

                    }) ; 

                }
               
                return View(newList);
            }


        }



        // GET: Beds/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Beds/Create
        [HttpPost]
        public ActionResult Create(CurrentBedModel bedObj)
        {
            HospitalManagementEntities db = new HospitalManagementEntities();
            if (ModelState.IsValid)
            {
                CurrentBedTb obj = new CurrentBedTb();

                var getMaxCurrentBedId = (from c in db.CurrentBedTbs where c.CurrentBedID != 0 orderby c.CurrentBedID descending select c.CurrentBedID).ToList();
                if (getMaxCurrentBedId.Count > 0)
                {
                    obj.CurrentBedID = 1 + getMaxCurrentBedId.First();
                }


                obj.BedTypeId = bedObj.BedTypeId;
                obj.CategoryId = bedObj.CategoryId;
                obj.SubCategoryId = bedObj.SubCategoryId;
                obj.Count = bedObj.Count;
                 obj.Opex = bedObj.Opex;

                obj.Status = bedObj.Status;

                db.CurrentBedTbs.Add(obj);
                db.SaveChanges();
                ViewBag.Message = "Save Sucessfuly";
                



            }

            ViewData["CurrentBeds"] = db.CurrentBedTbs.ToList();

            return View();
        }


     

        // POST: Beds/Create

        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Beds/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Beds/Edit/5
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

        // GET: Beds/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Beds/Delete/5
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
