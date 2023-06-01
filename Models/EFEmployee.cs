using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping2.Models
{
    public class EFEmployee: IEmployee
    {
        private ApplicationDbContext context;

        public EFEmployee(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Employee> Employees => context.Employees;
        public void SaveEmployee(Employee employee)
        {
            if (employee.EmployeeID == 0)
            {
                context.Employees.Add(employee);
            }
            else
            {
                Employee dbEntry = context.Employees
                .FirstOrDefault(p => p.EmployeeID == employee.EmployeeID);
                if (dbEntry != null)
                {
                    dbEntry.Name = employee.Name;
                    dbEntry.Surname = employee.Surname;
                    dbEntry.Gender = employee.Gender;
                    dbEntry.GradeLevel = employee.GradeLevel;
                }
            }
            context.SaveChanges();
        }
        public Employee DeleteEmployee(int empId)
        {
            Employee dbEntry = context.Employees
            .FirstOrDefault(p => p.EmployeeID == empId);
            if (dbEntry != null)
            {
                context.Employees.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
