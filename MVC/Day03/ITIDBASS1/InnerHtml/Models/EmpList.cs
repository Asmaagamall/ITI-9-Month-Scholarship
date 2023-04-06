using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnerHtml.Models
{
    public class EmpList
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){Id = 1 , Name = "Asmaa" , Salary = 2000},
            new Employee(){Id = 2 , Name = "Ahmed" , Salary = 3000},
            new Employee(){Id = 3 , Name = "Ali" , Salary = 4000},
            new Employee(){Id = 4 , Name = "Alaa" , Salary = 5000},
            new Employee(){Id = 5 , Name = "Amr" , Salary = 6000},
            new Employee(){Id = 6 , Name = "Reem" , Salary = 7000},
        };
    }
}