using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMIOC;
using IHRMBLL;
using Newtonsoft.Json;
using HRMModel;
namespace HRMUI.Controllers
{
    public class config_majorController : Controller
    {
        Iconfig_majorBLL bll = IocContanier.Createconfig_majorBLL();
        // GET: config_major
        public ActionResult Index()
        {
            //config_majorModel c = new config_majorModel()
            //{
            //    major_kind_id="01",
            //    major_kind_name= "软件开发",
            //    major_id="01",
            //    major_name= "区域经理",
            //    test_amount=0
            //};  //zhes
            //int cs= bll.Add(c);
            return View();
        }

        public ActionResult FillTable()   //查询
        {
           List<config_majorModel> list= bll.QueALL();
            return Content(JsonConvert.SerializeObject(list));
        }


        // GET: config_major/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: config_major/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: config_major/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
          
            string major_kind_id = Request["major_kind_id"];
            string major_kind_name = Request["major_kind_name"];
             string major_id = Request["major_id"];
            string major_name = Request["major_name"];
            config_majorModel c = new config_majorModel()
            {
                major_kind_id = major_kind_id,
                major_kind_name = major_kind_name,
                major_id= major_id,
                major_name= major_name
            };
            int add = bll.Add(c);
            if (add > 0)    
            {
                return JavaScript("alert('新增成功');window.location.href='/config_major/Index'");
            }
            else
            {
                return JavaScript("alert('新增失败');window.location.href='/config_major/Index'");
            }
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

        // GET: config_major/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_major/Edit/5
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

        // GET: config_major/Delete/5
        [HttpPost]
        public ActionResult Del(int id)
        {

            config_majorModel c = new config_majorModel()
            {
                Id = id
            };
            int delete = bll.Delete(c);
            if (delete > 0)
            {
                return Content("1");
            }
            else
            {
                return Content("0");
            }
        }

        // POST: config_major/Delete/5
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
