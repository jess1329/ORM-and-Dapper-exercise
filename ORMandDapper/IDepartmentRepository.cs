using System;
using System.Collections.Generic;
using System.Text;

namespace ORMandDapper
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
        