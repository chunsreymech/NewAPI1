using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAPI1.Models
{
    public class Employee
    {
        public int EmpId { get; set;}
        public string EmpName { get; set;}
        public string EmpEmail { get; set;} = "";
        public string EmpPhone { get; set;} = "";
        public DateTime EmpDOB { get; set;} = DateTime.Now;        
    }
}