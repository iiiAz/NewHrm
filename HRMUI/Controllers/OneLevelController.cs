using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMModel;
using HRMIOC;
using HRMUtility;
using IHRMBLL;
using Newtonsoft.Json;
namespace HRMUI.Controllers
{
    public class OneLevelController : Controller
    {
        IOneLevelBLL ob = IocContanier.CreateOneLevelBLL();
       
        // GET: OneLevel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OneLevelShow()
        {
            List<OneLevelModel> list = ob.QueryAll();
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: OneLevel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OneLevel/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: OneLevel/Create
        [HttpPost]
        public ActionResult Create(OneLevelModel  om)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int num = ob.Add(om);
                    if (num > 0)
                    {
                        return JavaScript("window.location.href='/OneLevel/OneLevel_Create_success'");
                    }
                    else {
                        ViewBag.dt = om;
                        return View();
                    }
                }
                else {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: OneLevel/Edit/5
        public ActionResult Edit(string id)
        {
            OneLevelModel om = new OneLevelModel()
            {
                Id=int.Parse(id)
            };
            List<OneLevelModel> list = ob.SeleteBys(om);
            OneLevelModel oo = new OneLevelModel()
            {
                Id=list[0].Id,
                first_kind_id= list[0].first_kind_id,
                first_kind_name= list[0].first_kind_name,
                first_kind_salary_id= list[0].first_kind_salary_id,
                first_kind_sale_id= list[0].first_kind_sale_id
            };
            return View(oo);         
        }

        // POST: OneLevel/Edit/5
        [HttpPost]
        public ActionResult Edit(OneLevelModel om)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int num = ob.Update(om);
                    if (num > 0)
                    {
                        return JavaScript("window.location.href='/OneLevel/OneLevel_Change_success'");
                    }
                    else {
                        ViewBag.dt = om;
                        return View();
                    }
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        public ActionResult OneLevel_Change_success()
        {
            return View();
        }

        

        public ActionResult OneLevel_Create_success()
        {
            return View();
        }

        public ActionResult Delete(string id)
        {
            try
            {
                OneLevelModel od = new OneLevelModel()
                {
                    Id=int.Parse(id)
                };

                int num = ob.Delete(od);
                if (num > 0)
                {
                    return Content("ok");
                }
                else {
                    return Content("on");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
