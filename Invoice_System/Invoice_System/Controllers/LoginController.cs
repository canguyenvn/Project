using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Invoice_System.Models;


namespace Invoice_System.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.User_Name, Encryptor.MD5Hash(model.User_Password), true);
                if (result == 1)
                {
                    var user = dao.GetById(model.User_Name);
                    var userSession = new UserLogin();
                    userSession.UserName = user.User_Name;
                    userSession.UserID = user.User_ID;
                    userSession.GroupID = user.tbl_User_Relationship.;
                    var listCredentials = dao.GetListCredential(model.User_Name);

                    Session.Add(CommonConstants.SESSION_CREDENTIALS, listCredentials);
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Account is not exist.");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Account is locked.");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Password is incorrect.");
                }
                else if (result == -3)
                {
                    ModelState.AddModelError("", "Account is not allowed access.");
                }
                else
                {
                    ModelState.AddModelError("", "Cannot login.");
                }
            }
            return View("Index");
        }

    }
}