// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TaskController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the TaskController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.Controllers
{
    using System;

    using MakeBeauty.Data.Entities;
    using MakeBeauty.Repositories;
    using MakeBeauty.ViewModels;

    using System.Web.Mvc;

    public class TaskController : Controller
    {
        private TaskRepository taskRepository = new TaskRepository();

        //
        // GET: /Task/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }


        //
        // GET: /Task/Create

        public ActionResult Create()
        {
            var task = taskRepository.Create();

            var entities = new MakeBeautyEntities().HairStyles;

            return View(new TaskViewModel(task, entities));
        } 

        //
        // POST: /Task/Create

        [HttpPost]
        public ActionResult Create(TaskViewModel taskViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    taskRepository.Insert(taskViewModel.GetOriginalSource());

                    return RedirectToAction("Index", "HairStyle");
                }

                return View(taskViewModel);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        
    

    
    }
}
