using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMIOC;
using IHRMBLL;
using HRMModel;
using Newtonsoft.Json;
namespace HRMUI.Controllers
{
    public class iCharController : Controller
    {
        IConfig_public_charBLL icpb = IocContanier.CreateChar_BLL();
        // GET: Char
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Ajax查询config_public_char全部
        /// </summary>
        /// <returns></returns>
        public ActionResult FillTable()
        {
            List<config_public_charModel> listAll = icpb.QueryAll();
            return Content(JsonConvert.SerializeObject(listAll));
        }

        #region config_public_char新增
        // GET: Char/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Char/Create
        [HttpPost]
        public ActionResult Create(config_public_charModel cpcm)
        {
            try
            {
                if (ModelState.IsValid)//后台验证
                {
                    config_public_charModel cc = new config_public_charModel()
                    {
                        attribute_kind = cpcm.attribute_kind,
                        attribute_name = cpcm.attribute_name
                    };
                    int a = icpb.Add(cc);
                    if (a > 0)
                        return JavaScript(@"alert('^_^添加成功');window.location.href='/iChar/Index'");
                    else
                        return JavaScript("alert('信息错误,请重新试');window.location.href='/iChar/Create'");
                }
                else
                {
                    return RedirectToAction("Create");
                }
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }


        [HttpGet]
        public ActionResult CreateAboutPay()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAboutPay(config_public_charModel cpcm)
        {
            try
            {
                if (ModelState.IsValid)//后台验证
                {
                    config_public_charModel cc = new config_public_charModel()
                    {
                        attribute_kind = "薪酬设置",
                        attribute_name = cpcm.attribute_name
                    };
                    int a = icpb.Add(cc);
                    if (a > 0)
                        return JavaScript(@"alert('^_^添加成功');window.location.href='/iChar/SelectBy'");
                    else
                        return JavaScript("alert('信息错误,请重新试');window.location.href='/iChar/CreateAboutPay'");
                }
                else
                {
                    return RedirectToAction("CreateAboutPay");
                }
            }
            catch(Exception)
            {
                return RedirectToAction("SelectBy");
            }
        }
        #endregion

        #region 修改
        // GET: Char/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Char/Edit/5
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
        #endregion

        /// <summary>
        /// 表config_public_char删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Char/Delete/5
        public ActionResult Delete(int id)
        {
            config_public_charModel cc = new config_public_charModel()
            {
                Id  = id
            };
            int a = icpb.Delete(cc);
            if (a > 0)
            {
                return Content("okk");//(@"alert('您已完成操作');window.location.href='/iChar/Index'");
            }
            else {
                return Content("Thanks");
            }
        }


        /// <summary>
        /// 查询Kind为薪酬设置
        /// </summary>
        /// <returns></returns>
        public ActionResult SelectBy() {
            return View();
        }
        public ActionResult SelectByattribute_kind() {
            try
            {
                config_public_charModel cpc = new config_public_charModel() {
                    attribute_kind = "薪酬设置"
                };

                List<config_public_charModel> listBy = icpb.SelectByx(cpc);
                return Content(JsonConvert.SerializeObject(listBy));

            }
            catch (Exception)
            {
                //LogHelper.WriteLog(typeof(UseresController), e);
                return View();
            }
        }


    }
}
