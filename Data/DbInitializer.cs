using WebApplication7.Models;
using System;
using System.Linq;

namespace WebApplication7.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmployeesContext context) {
            context.Database.EnsureCreated();

            if (context.Employee.Any())
            {
                return;
            }

            var employee = new Employee[]
                {
                    new Employee{EmployeeID="EM001", Name="jonh Carter", Department="HR", Salary=3000},
                    new Employee{EmployeeID="EM002", Name="Michael Bean", Department="SC", Salary=1300},
                    new Employee{EmployeeID="EM003", Name="Jimmy Floy", Department="MD", Salary=2000},
                    new Employee{EmployeeID="EM004", Name="Mary Brown", Department="MD", Salary=2000}
                };
                foreach(Employee s in employee)
                {
                    context.Employee.Add(s);
                }
                context.SaveChanges();
        }
    }
}
