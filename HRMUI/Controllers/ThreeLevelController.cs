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
    public class ThreeLevelController : Controller
    {
        IThreeLevelBLL tb = IocContanier.CreateThreeLevelBLL();
        ITwoLevelBLL tb2 = IocContanier.CreateTwoLevelBLL();
        IOneLevelBLL tb1 = IocContanier.CreateOneLevelBLL();
        // GET: ThreeLevel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowThreeLevel()
        {
            List<ThreeLevelModel> list = tb.QueryAll();
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpGet]
        public ActionResult Edit(string id) {
            seleitem();
            ThreeLevelModel om = new ThreeLevelModel()
            {
                Id = int.Parse(id)
            };
            List<ThreeLevelModel> list = tb.SeleteBys(om);
            ThreeLevelModel oo = new ThreeLevelModel()
            {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id= list[0].second_kind_id,
                second_kind_name= list[0].second_kind_name,
                third_kind_sale_id= list[0].third_kind_sale_id,
                third_kind_is_retail= list[0].third_kind_is_retail,
                third_kind_id = list[0].third_kind_id,
                third_kind_name= list[0].third_kind_name
            };
            return View(oo);
        }

        public void seleitem() {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                 new SelectListItem {Text="是",Value="是",Selected=true },
                new SelectListItem {Text="否",Value="否",Selected=true  }
            };
            ViewBag.dy = list;
        }

        [HttpPost]
        public ActionResult Edit(ThreeLevelModel  tm)
        {
            int num = tb.Update(tm);
            if (num > 0)
            {
                return RedirectToAction("ThreeLevel_Change_success");
            }
            else
            {
                ViewBag.dt = tm;
                return View();
            }
        }

        public void FirstName()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<OneLevelModel> list2 = tb1.QueryAll();
            foreach (OneLevelModel item in list2)
            {
                SelectListItem om = new SelectListItem()
                {
                    Text = item.first_kind_name.ToString(),
                    Value = item.first_kind_id.ToString()
                };
                list.Add(om);
            }
            ViewBag.First = list;
        }

        public void SecondName()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<TwoLevelModel> list2 = tb2.QueryTwoLevelAll();
            foreach (TwoLevelModel item in list2)
            {
                SelectListItem om = new SelectListItem()
                {
                    Text = item.second_kind_name.ToString(),
                    Value = item.second_kind_id.ToString(),
                };
                list.Add(om);
            }
            ViewBag.Second= list;
        }



        public ActionResult ThreeLevel_Change_success() {
            return View();
        }

        [HttpGet]
        public ActionResult Create(ThreeLevelModel tm)
        {
            FirstName();
            SecondName();
            seleitem();
            return View();
        }

        [HttpPost]
        public ActionResult CreateThreeLevel(ThreeLevelModel tm) {

            OneLevelModel oneid = new OneLevelModel()
            {
                first_kind_id = tm.first_kind_id
            };

            TwoLevelModel twoid = new TwoLevelModel()
            {
                second_kind_id=tm.second_kind_id
            };
            List<OneLevelModel> list = tb1.SeleteByx(oneid);
            List<TwoLevelModel> list2 = tb2.SeleteByx(twoid);
            ThreeLevelModel tm2 = new ThreeLevelModel()
            {
              
                first_kind_id=tm.first_kind_id,
                first_kind_name=list[0].first_kind_name,
                second_kind_id=tm.second_kind_id,
                second_kind_name=list2[0].second_kind_name,
                third_kind_id=tm.third_kind_id,
                third_kind_is_retail=tm.third_kind_is_retail,
                third_kind_name=tm.third_kind_name,
                third_kind_sale_id=tm.third_kind_sale_id
            };
            int num = tb.Add(tm2);
            if (num > 0)
            {
                return RedirectToAction("ThreeLevel_Create_success");
            }
            else {
                return View();
            }
        }
        public ActionResult ThreeLevel_Create_success() {

            return View();
        }

        public ActionResult Delete(string id) {
            try
            {
                ThreeLevelModel od = new ThreeLevelModel()
                {
                    Id = int.Parse(id)
                };

                int num = tb.Delete(od);
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

    }
}