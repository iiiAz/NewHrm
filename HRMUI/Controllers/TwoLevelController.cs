using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMModel;
using HRMIOC;
using HRMUtility;
using Newtonsoft.Json;
using IHRMBLL;
using System.Data;

namespace HRMUI.Controllers
{
    public class TwoLevelController : Controller
    {
        ITwoLevelBLL tb = IocContanier.CreateTwoLevelBLL();
        IOneLevelBLL ob = IocContanier.CreateOneLevelBLL();
        // GET: TwoLevel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TwoLevelShow()
        {
            List<TwoLevelModel> list = tb.QueryTwoLevelAll();
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: TwoLevel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public void FillDrop() {
            List<SelectListItem> list = new List<SelectListItem>();
            List<OneLevelModel> list2 = ob.QueryAll();
            foreach (OneLevelModel item in list2)
            {
                SelectListItem om = new SelectListItem()
                {
                 Text=item.first_kind_name.ToString(),
                 Value=item.first_kind_id.ToString()
                }; 
                list.Add(om);
            }
            ViewBag.list = list;
        }

        // GET: TwoLevel/Create
        [HttpGet]
        public ActionResult Create()
        {
            FillDrop();
            return View();
        }

        // POST: TwoLevel/Create
        [HttpPost]
        public ActionResult Create(TwoLevelModel  tm)
        {
            try
            {
                OneLevelModel oneid = new OneLevelModel() {
                    first_kind_id = tm.first_kind_id
                };


                List<OneLevelModel> firstkindnameL = ob.SeleteByx(oneid);
                TwoLevelModel tm2 = new TwoLevelModel() {
                    //Id = tm.Id,
                    first_kind_id = tm.first_kind_id,
                    first_kind_name = firstkindnameL[0].first_kind_name,
                    second_kind_id=tm.second_kind_id,
                    second_kind_name=tm.second_kind_name,
                    second_salary_id=tm.second_salary_id,
                    second_sale_id=tm.second_sale_id
                };

                    int num = tb.AddTwoLevel(tm2);
                    if (num > 0)
                    {
                        return RedirectToAction("TwoLevel_Create_success");
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

        // GET: TwoLevel/Edit/5
        public ActionResult Edit(string id)
        {
            TwoLevelModel tm = new TwoLevelModel()
            {
                Id = int.Parse(id)
            };

            List<TwoLevelModel> list = tb.SeleteTwoLevelBys(tm);
            TwoLevelModel to = new TwoLevelModel()  
            {
                Id=list[0].Id,
                first_kind_id=list[0].first_kind_id,
                first_kind_name=list[0].first_kind_name,
                second_kind_id= list[0].second_kind_id,
                second_kind_name= list[0].second_kind_name,
                second_salary_id= list[0].second_salary_id,
                second_sale_id= list[0].second_sale_id
            };
            return View(to);
        }

        // POST: TwoLevel/Edit/5
        [HttpPost]
        public ActionResult Edit(TwoLevelModel tm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int num = tb.UpdateTwoLevel(tm);
                    if (num > 0)
                    {
                        return RedirectToAction("TwoLevel_Change_success");
                    }
                    else {
                        ViewBag.dt = tm;
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


        

             public ActionResult TwoLevel_Change_success()
        {
            return View();
        }


        // POST: TwoLevel/Delete/5
        public ActionResult Delete(string  id)
        {
            try
            {
                TwoLevelModel od = new TwoLevelModel()
                {
                    Id = int.Parse(id)
                };

                int num = tb.DeleteTwoLevel(od);
                if (num > 0)
                {
                    return Content("ok");
                }
                else
                {
                    return Content("on");
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult TwoLevel_Del_success(){
            return View();
        }

        public ActionResult TwoLevel_Create_success()
        {
            return View();
        }
    }
}
