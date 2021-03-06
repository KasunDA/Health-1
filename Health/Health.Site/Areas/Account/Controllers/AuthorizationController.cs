﻿using System.Web.Mvc;
using Health.Core.API;
using Health.Core.API.Services;
using Health.Site.Areas.Account.Models;
using Health.Site.Attributes;
using Health.Site.Controllers;

namespace Health.Site.Areas.Account.Controllers
{
    public class AuthorizationController : CoreController
    {
        public AuthorizationController(IDIKernel diKernel) : base(diKernel)
        {
        }

        /// <summary>
        /// Отображение формы входа
        /// </summary>
        /// <returns></returns>
        [PRGImport]
        public ActionResult Login(LoginForm form)
        {
            return View(form);
        }

        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost, PRGExport]
        public ActionResult LoginSubmit(LoginForm form)
        {
            if (ModelState.IsValid)
            {
                if (Get<IAuthorizationService>().Login(form.Login, form.Password, form.RememberMe))
                {
                    return RedirectTo<Admin.Controllers.HomeController>(a => a.Index());
                }
            }
            return RedirectTo<AuthorizationController>(a => a.Login(form));
        }

        /// <summary>
        /// Выход пользователя
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            Get<IAuthorizationService>().Logout();

            return RedirectTo<HomeController>(a => a.Index());
        }
    }
}