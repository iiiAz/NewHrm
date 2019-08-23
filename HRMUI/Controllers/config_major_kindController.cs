using HRMIOC;
using IHRMBLL;
using HRMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
namespace HRMUI.Controllers
{
    public class config_major_kindController : Controller
    {
        Iconfig_major_kindBLL bll = IocContanier.Createconfig_major_kind_BLL();
        // GET: config_major_kind
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FillTable()   //显示全部
        {
           List<config_major_kindModel> list= bll.QueryAll();
            return  Content(JsonConvert.SerializeObject(list));
        }

        // GET: config_major_kind/Details/5
        public ActionResult Details(int id)
        {
          
            return View();
        }

        public ActionResult Del(int id) {
            config_major_kindModel c = new config_major_kindModel()
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
        // GET: 新增
        public ActionResult Create()
        {
            return View();
        }

        // POST: config_major_kind/Create   提交新增
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            string name=Request["name"];
            string id = Request["id"];
            config_major_kindModel c = new config_major_kindModel()
            {
                major_kind_id = id,
                major_kind_name = name
            };
          int add=  bll.Add(c);
            if (add>0)
            {
                return JavaScript("alert('新增成功');window.location.href='/config_major_kind/Index'");
            }
            else
            {
                return JavaScript("alert('新增失败');window.location.href='/config_major_kind/Index'");
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

        // GET: config_major_kind/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_major_kind/Edit/5
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

        // GET: config_major_kind/Delete/5   删除
        public ActionResult Delete(int id)
        {
            config_major_kindModel c = new config_major_kindModel()
            {
                Id = id
            };
            int delete = bll.Delete(c);
            ViewBag.d = delete;
            if (delete>0)
            {
                return  RedirectToAction ("Index");
            }
            else
            {
                return Content("alert('删除失败');window.location.href='/config_major_kind/Index'");
            }

        }

        // POST: config_major_kind/Delete/5
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
