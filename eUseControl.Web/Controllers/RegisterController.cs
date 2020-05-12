using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using eUseControl.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace eUseControl.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISession _session;
        public RegisterController()
        {
            var b1 = new BussinesLogic();
            _session = b1.GetSessionBL();
        }



        // GET: Register
        public ActionResult Register()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserRegister data)
        {

            if (ModelState.IsValid)
            {
                URegisterData user = new URegisterData
                {
                    Credential = data.Credential,
                    Password = data.Password,
                    Email = data.Email,
                    Informatie = data.Informatie,
                    RegisterDateTime = DateTime.Now
                };



                ULoginResp userRegistration = _session.UserRegister(user);
                if (userRegistration.Status)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userRegistration.StatusMsg);
                    return View();
                }



            }
            return View();



        }
    }
}