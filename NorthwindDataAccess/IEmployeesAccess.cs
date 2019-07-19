using Nothwind.Common.DTO;

namespace Northwind.DataAccess
{
    public interface IEmployeesAccess
    {
        bool EmployeesAdd(EmployeesDTO DTO);
        bool EmployeesRemove(EmployeesDTO DTO);
        bool EmployeesMod(EmployeesDTO DTO);
    }
}
