using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMModel;
using HRMIOC;
using IHRMBLL;
using HRMUtility;
using Newtonsoft.Json;
namespace HRMUI.Controllers
{
    public class UseresController : Controller
    {
        IUserBLL iub = IocContanier.CreateUser_BLL();

        /// <summary>
        /// GET: Useres 登录的显示页面
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestLogin()
        {
            return View();
        }

        // GET: Useres/Create
        #region 新增用户
        public ActionResult Create()
        {
            return View();
        }

        // POST: Useres/Create
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
        #endregion

        // GET: Useres/Edit/5
        #region 修改用户信息
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Useres/Edit/5
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

        // GET: Useres/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="muser"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(UserModel muser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string name = muser.u_name;
                    List<UserModel> list = iub.SelectByx(muser);
                    if (list.Count > 0)
                        return JavaScript(@"alert('欢迎--" + list[0].u_name + "');window.location.href='/Home/MainIndex'");
                    else
                        return JavaScript("alert('账号或密码错误');window.location.href='/Useres/Index'");
                }
                return View();
            }
            catch (Exception)
            {
                //LogHelper.WriteLog(typeof(UseresController), e);
                return View();
            }
        }
    }
}
