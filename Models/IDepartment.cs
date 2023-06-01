using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping2.Models
{
  public interface IDepartment

    {
        IQueryable<Department> Departments { get; }
        void SaveDepartment(Department department);
        Department DeleteDepartment(int deptId);
    }
}
