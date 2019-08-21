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
        // GET: Useres
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestLogin()
        {
            return View();
        }

        // GET: Useres/Create
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

        // GET: Useres/Edit/5
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

        // GET: Useres/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult Login(UserModel muser)
        {
            try
            {
                string name = muser.u_name;
                List<UserModel> list = iub.SelectByx(muser);
                if (list.Count > 0)
                {
                    //return Content("<script>alert(‘成功’);window.location.href='/Test/Index'</script>");
                    return RedirectToAction("TestLogin");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                //LogHelper.WriteLog(typeof(UseresController), e);
                return View();
            }



        }
    }
}
