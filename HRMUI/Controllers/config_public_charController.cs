using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMModel;
using HRMIOC;
using IHRMBLL;
using Newtonsoft.Json;


namespace HRMUI.Controllers
{
    public class config_public_charController : Controller
    {
        // GET: config_public_char
        public ActionResult Index()
        {
            return View();
        }
        Iconfig_public_charBLL bll = IocContanier.CreateIconfig_public_charBLL();
        public ActionResult FillTable()   //显示全部
        {
           List<config_public_charModel> list= bll.QueryAll();
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: config_public_char/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: config_public_char/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: config_public_char/Create
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

        // GET: config_public_char/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_public_char/Edit/5
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

        // GET: config_public_char/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: config_public_char/Delete/5
        [HttpPost]
        public ActionResult Deete(int id)
        {
            config_public_charModel c = new config_public_charModel()
            {
                pbc_Id = id
            };
           int delete= bll.Delete(c);
            if (delete>0)
            {
                return Content("1");
            }
            else
            {
                return Content("0");
            }

        }
    }
}
