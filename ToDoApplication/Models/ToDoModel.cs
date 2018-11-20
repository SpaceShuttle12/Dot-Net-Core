using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApplication.Models
{
    public class ToDoModel
    {
        public string TaskGuid { get; set; }
        [Display(Name = "lblName", ResourceType = typeof(Resources.Common))]
        public string TaskName { get; set; }
        [Display(Name = "lblDescription", ResourceType = typeof(Resources.Common))]
        public string TaskDescription { get; set; }
        [Display(Name = "lblStatus", ResourceType = typeof(Resources.Common))]
        public int TaskStatus { get; set; }
        public string StatusName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
