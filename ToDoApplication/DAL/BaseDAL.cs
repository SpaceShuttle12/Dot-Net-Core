using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ToDoApplication.DAL
{
    public class BaseDAL
    {
        protected readonly IConfiguration configuration;
        public string connectionString = string.Empty;


        public BaseDAL(IConfiguration config)
        {
            this.configuration = config;
            connectionString = configuration.GetConnectionString("ToDO");
        }
    }
}
