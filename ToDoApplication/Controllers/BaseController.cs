using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace ToDoApplication.Controllers
{
    public class BaseController : Controller
    {
        public readonly IConfiguration configuration;
        public string connectionString = string.Empty;
        public BaseController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var actionDescriptor = filterContext.ActionDescriptor;
            var actionName = actionDescriptor.DisplayName;
            var controllerName = filterContext.Controller.ToString();
            connectionString = configuration.GetConnectionString("ToDoApp");
        }
    }
}