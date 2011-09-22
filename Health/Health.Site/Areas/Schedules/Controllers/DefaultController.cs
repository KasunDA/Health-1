﻿using System.Web.Mvc;
using Health.Core.API;
using Health.Core.Entities.POCO;
using Health.Site.Areas.Schedules.Models;
using Health.Site.Attributes;
using Health.Site.Controllers;
using Health.Site.Models.Configuration.Providers;
using Health.Site.Models.Providers;

namespace Health.Site.Areas.Schedules.Controllers
{
    public class DefaultController : CoreController
    {
        public DefaultController(IDIKernel di_kernel) : base(di_kernel)
        {
        }

        public ActionResult Index()
        {
            var view_model = new DefaultScheduleList
                                 {
                                     DefaultSchedules = CoreKernel.DefaultScheduleRepo.GetAll()
                                 };
            return View(view_model);
        }

        [PRGImport(ParametersHook = true)]
        public ActionResult Edit(int schedule_id = 1)
        {
            DefaultSchedule default_schedule = CoreKernel.DefaultScheduleRepo.GetById(schedule_id);
            var view_model = new DefaultScheduleForm
                                 {
                                     DefaultSchedule = default_schedule
                                 };
            return View(view_model);
        }

        [PRGExport(ParametersHook = true)]
        public ActionResult EditSubmit(DefaultScheduleForm form)
        {
            if (ModelState.IsValid)
            {
                CoreKernel.DefaultScheduleRepo.Update(form.DefaultSchedule);
                form.Message = "Расписание отредактировано";
                return RedirectTo<DefaultController>(a => a.Confirm(form));
            }
            return RedirectTo<DefaultController>(a => a.Edit(form.DefaultSchedule.Id));
        }

        [PRGImport(ParametersHook = true)]
        public ActionResult Add(DefaultScheduleForm form)
        {
            MetadataBinder.For<Parameter>().Use<MMPAAttributeOnly, ClassMetadataConfigurationProvider>().
                WithConfigurationParameters(typeof (DefaultScheduleAddMetadata));
            form = form ?? new DefaultScheduleForm
                               {
                                   DefaultSchedule = new DefaultSchedule()
                               };
            return View(form);
        }

        [PRGExport(ParametersHook = true)]
        public ActionResult AddSubmit([Bind(Include = "DefaultSchedule")] DefaultScheduleForm form)
        {
            MetadataBinder.For<Parameter>().Use<MMPAAttributeOnly, ClassMetadataConfigurationProvider>().
                WithConfigurationParameters(typeof (DefaultScheduleAddMetadata));
            if (ModelState.IsValid)
            {
                CoreKernel.DefaultScheduleRepo.Save(form.DefaultSchedule);
                form.Message = "Расписание добавлено";
                return RedirectTo<DefaultController>(a => a.Confirm(form));
            }
            return RedirectTo<DefaultController>(a => a.Add(form));
        }

        public ActionResult Delete(int schedule_id)
        {
            CoreKernel.DefaultScheduleRepo.DeleteById(schedule_id);
            return RedirectTo<DefaultController>(a => a.Index());
        }

        [PRGImport(ParametersHook = true)]
        public ActionResult Confirm(DefaultScheduleForm form)
        {
            if (form.DefaultSchedule == null) return RedirectTo<DefaultController>(a => a.Index());
            return View(form);
        }
    }
}
