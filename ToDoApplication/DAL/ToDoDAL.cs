using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using ToDoApplication.Models;
using Microsoft.Extensions.Configuration;

namespace ToDoApplication.DAL
{
    public class ToDoDAL
    {
        //public static string connectionString = string.Empty;
        SqlConnection sqlConnection;
        public ToDoDAL(string configuration)
        {
            sqlConnection = new SqlConnection(configuration);
        }
        //string strConnection = Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString(this.Configuration,"DefaultConection");
        //SqlConnection sqlConnection = new SqlConnection();
        //static string connection = @"Data Source=LAPTOP-MECJL3AV\SQLEXPRESS;Initial Catalog=ToDO;Integrated Security=False;Persist Security Info=False;User Id = sa;Password = algo@123;";
        
       
        public DataSet StatusGet()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("StatusGet",sqlConnection)) {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.Fill(dt);
                    ds.Tables.Add(dt);
                }
            }
            catch (Exception exec)
            {
                throw;
            }
            return ds;
        }

        public int SaveTask(ToDoModel toDo)
        {
            int result = 1;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlCommand sqlCommand = new SqlCommand("Task_Add", sqlConnection))
            {
                sqlCommand.Parameters.Add(new SqlParameter("@P_TaskName", toDo.TaskName));
                sqlCommand.Parameters.Add(new SqlParameter("@P_TaskDescription", toDo.TaskDescription));
                sqlCommand.Parameters.Add(new SqlParameter("@p_TaskStatus", toDo.TaskStatus));
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //sqlDataAdapter.Fill(dt);
                ds = getDataSet(sqlCommand, "insert");
                result = getResult(ds.Tables[0]);
            }
            return result;
        }


        public int UpdateTask(ToDoModel model)
        {
            int result = 1;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlCommand sqlCommand = new SqlCommand("Task_Update", sqlConnection))
            {
                sqlCommand.Parameters.Add(new SqlParameter("@P_TaskName", model.TaskName));
                sqlCommand.Parameters.Add(new SqlParameter("@P_TaskDescription", model.TaskDescription));
                sqlCommand.Parameters.Add(new SqlParameter("@P_TaskStatus", model.TaskStatus));
                sqlCommand.Parameters.Add(new SqlParameter("@P_TaskGuid", model.TaskGuid));
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //sqlDataAdapter.Fill(dt);
                ds = getDataSet(sqlCommand, "update");
                result = getResult(ds.Tables[0]);
            }
            return result;
        }

        public int DeleteTask(string id)
        {
            int result = 1;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (SqlCommand sqlCommand = new SqlCommand("Task_Delete", sqlConnection))
            {
                sqlCommand.Parameters.Add(new SqlParameter("@P_TaskGuid", id));
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //sqlDataAdapter.Fill(dt);
                ds = getDataSet(sqlCommand, "update");
                result = getResult(ds.Tables[0]);
            }
            return result;
        }

        public DataSet TaskList(string id) {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                
                using (SqlCommand sqlCommand = new SqlCommand("Task_Get",sqlConnection))
                {
                    if (string.IsNullOrEmpty(id))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@P_TaskGuid", null));
                    }
                    else {
                        sqlCommand.Parameters.Add(new SqlParameter("@P_TaskGuid", id));
                    }
                    ds = getDataSet(sqlCommand, "");
                }
                
            }
            catch (Exception exec)
            {

                throw;
            }
            return ds;
        }

        #region Private methods
        private int getResult(DataTable dt)
        {
            int result = -1;
            foreach (DataRow item in dt.Rows)
            {
                result = Convert.ToInt32(item["RESULT"]);
            }
            return result;
        }
        private DataSet getDataSet(SqlCommand sqlCommand, string commandType)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            switch (commandType)
            {
                case "insert":
                    sqlDataAdapter.InsertCommand = sqlCommand;
                    break;
                case "update":
                    sqlDataAdapter.UpdateCommand = sqlCommand;
                    break;
                default:
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    break;

            }

            sqlDataAdapter.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}
