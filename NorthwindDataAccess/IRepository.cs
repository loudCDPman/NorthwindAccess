using Nothwind.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess
{
    public interface IRepository
    {
        IEnumerable<EmployeesDTO> GetEmployees();
        EmployeesDTO GetEmployee(int id);
        bool EmployeesAdd(EmployeesDTO dto);
        bool EmployeesRemove(EmployeesDTO dto);
        bool EmployeesMod(EmployeesDTO dto);
    }
}
