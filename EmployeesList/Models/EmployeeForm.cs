using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesList.Models
{
    public class EmployeeForm
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int ReportsToId { get; set; }
         
    }
}
