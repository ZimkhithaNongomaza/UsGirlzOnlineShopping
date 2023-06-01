using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping2.Models
{
   public interface IEmployee
    {
        IQueryable <Employee> Employees { get; }
        void SaveEmployee(Employee employee);
        Employee DeleteEmployee(int empId);
    }
}
