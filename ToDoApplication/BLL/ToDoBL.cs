using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ToDoApplication.DAL;
using ToDoApplication.Models;
using Microsoft.Extensions.Configuration;
namespace ToDoApplication.BLL
{
    public class ToDoBL
    {
        private static string connectionString;
        public ToDoBL(string connection)
        {
            connectionString = connection;
        }
        ToDoDAL objDal = new ToDoDAL(connectionString);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public List<SelectListItem> StatusListItem()
        {
            string statusName, statusId = string.Empty;
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(
                new SelectListItem
                {
                    Value = "0",
                    Text = "Select"
                }
           );
            ds = objDal.StatusGet();
            dt = ds.Tables[0];
            foreach (DataRow rows in dt.Rows)
            {
                list.Add(new SelectListItem
                {
                    Value = rows["StatusId"].ToString(),
                    Text = rows["StatusName"].ToString()
                });
            }
            return list;
        }

        public bool SaveTask(ToDoModel toDo)
        {
            bool success = false;
            int result = objDal.SaveTask(toDo);
            if (result == 0)
            {
                success = true;
            }
            return success;
        }

        public ToDoModel GetDetails(string id)
        {
            ToDoModel model = new ToDoModel();
            ds = objDal.TaskList(id);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                model.TaskDescription = Convert.ToString(item["TaskDescription"]);
                model.TaskName = Convert.ToString(item["TaskName"]);
                model.TaskGuid = Convert.ToString(item["TaskGuid"]);
                model.TaskStatus = Convert.ToInt32(item["TaskStatus"]);
            }
            return model;
        }

        public bool UpdateTask(ToDoModel model)
        {
            bool success = false;
            int result = objDal.UpdateTask(model);
            if (result == 0)
            {
                success = true;
            }
            return success;
        }

        public bool DeleteTask(string id)
        {
            bool success = false;
            int result = objDal.DeleteTask(id);
            if (result == 0)
            {
                success = true;
            }
            return success;
        }

        public List<ToDoModel> GetTaskList()
        {
            List<ToDoModel> toDoList = new List<ToDoModel>();
            ds = objDal.TaskList("");
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ToDoModel model = new ToDoModel();
                model.TaskName = Convert.ToString(item["TaskName"]);
                model.TaskDescription = Convert.ToString(item["TaskDescription"]);
                model.TaskStatus = Convert.ToInt32(item["TaskStatus"]);
                model.TaskGuid = Convert.ToString(item["TaskGuid"]);
                model.StatusName = Convert.ToString(item["StatusName"]);
                toDoList.Add(model);
            }
            return toDoList;

        }
    }
}
