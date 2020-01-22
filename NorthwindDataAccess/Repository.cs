using Northwind.DataAccess.Models;
using Nothwind.Common.DTO;
using Nothwind.Common.Services.MapperService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.DataAccess
{
    class Repository : IRepository
    {
        static NorthwindMapperConfigBuilder ConfigBuilder;
        public Repository()
        {

        }
        //public EmployeesDTO GetEmployee(int id)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        var employee = context
        //            .Employees
        //            .FirstOrDefault(x=>x.EmployeeId == id) 
        //            ?? throw new Exception("Employee not found");

        //        MapperService mapper = new MapperService(ConfigBuilder.GetConfiguration());
        //        var items = mapper.Map<Employees, EmployeesDTO>(employee);
        //        return items;
        //    }
        //}

        //public IEnumerable<EmployeesDTO> GetEmployees()
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        var employees = context.Employees.ToArray();
        //        MapperService mapper = new MapperService(ConfigBuilder.GetConfiguration());
        //        var items = mapper.Map<Employees, EmployeesDTO>(employees);
        //        return items;
        //    }
        //}

        public bool EmployeesAdd(EmployeesDTO dto)
        {
            throw new NotImplementedException();
        }

        public bool EmployeesMod(EmployeesDTO dto)
        {
            throw new NotImplementedException();
        }

        public bool EmployeesRemove(EmployeesDTO dto)
        {
            throw new NotImplementedException();
        }

        public EmployeesDTO GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeesDTO> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
