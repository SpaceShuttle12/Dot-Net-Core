using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApplication.BLL;
using ToDoApplication.Models;
using Microsoft.Extensions.Configuration;

namespace ToDoApplication.Controllers
{
    public class ToDoController : BaseController
    {
        public ToDoController(IConfiguration configuration) : base(configuration) { }
        public IActionResult Index()
        {
            
            ToDoBL objToDoBl = new ToDoBL(connectionString);
            List<ToDoModel> toDoList = new List<ToDoModel>();
            toDoList = objToDoBl.GetTaskList();
            return View(toDoList);
        }

        public IActionResult AddTask()
        {
            ToDoBL objToDoBl = new ToDoBL(connectionString);
            ViewBag.StatusList = objToDoBl.StatusListItem();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddTask(ToDoModel toDo)
        {
            ToDoBL objToDoBl = new ToDoBL(connectionString);
            bool blsuccess = false;
            string strMessage = string.Empty;
            blsuccess = objToDoBl.SaveTask(toDo);
            if (blsuccess)
            {
                strMessage = Resources.Common.SaveMessage;
            }
            else
            {
                strMessage = Resources.Common.InternalError;
            }
            return Json(new
            {
                success = blsuccess,
                message = strMessage
            });
        }

        public ActionResult EditTask(string id)
        {
            ToDoBL objToDoBl = new ToDoBL(connectionString);
            ToDoModel model = new ToDoModel();
            model = objToDoBl.GetDetails(id);
            ViewBag.SelectedValue = model.TaskStatus;
            ViewBag.StatusList = objToDoBl.StatusListItem();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditTask(ToDoModel model)
        {
            ToDoBL objToDoBl = new ToDoBL(connectionString);
            bool blSuccess = false;
            string strMessage = string.Empty;
            blSuccess = objToDoBl.UpdateTask(model);
            if (blSuccess)
            {
                strMessage = Resources.Common.UpdateMessage;
            }
            else
            {
                strMessage = Resources.Common.InternalError;
            }

            return Json(new
            {
                success = blSuccess,
                message = strMessage
            });
        }
        [HttpPost]
        public ActionResult DeleteTask(string id)
        {
            ToDoBL objToDoBl = new ToDoBL(connectionString);
            bool blSuccess = false;
            string strMessage = string.Empty;
            blSuccess = objToDoBl.DeleteTask(id);
            if (blSuccess)
            {
                strMessage = Resources.Common.UpdateMessage;
            }
            else
            {
                strMessage = Resources.Common.InternalError;
            }

            return Json(new
            {
                success = blSuccess,
                message = strMessage
            });
        }
    }
}