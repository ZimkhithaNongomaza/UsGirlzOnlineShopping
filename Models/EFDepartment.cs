using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping2.Models
{
    public class EFDepartment: IDepartment
    {

        private ApplicationDbContext context;
            public EFDepartment(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Department> Departments => context.Departments;
        public void SaveDepartment(Department department)
        {
            if (department.DeptID == 0)
            {
                context.Departments.Add(department);
            }
            else
            {
                Department dbEntry = context.Departments
                .FirstOrDefault(p => p.DeptID == department.DeptID);
                if (dbEntry != null)
                {
                    dbEntry.Name = department.Name;
                    dbEntry.Description = department.Description;
                  
                }
            }
            context.SaveChanges();
        }
        public Department DeleteDepartment(int deptId)
        {
            Department dbEntry = context.Departments
            .FirstOrDefault(p => p.DeptID == deptId);
            if (dbEntry != null)
            {
                context.Departments.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
