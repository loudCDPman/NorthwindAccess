using AutoMapper;
using Northwind.DataAccess.Models;
using Nothwind.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.DataAccess
{
    class GetEntitys
    {
        List<EmployeesDTO> GetEmployees()
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    //TODO autofax the models to DTO 
                    List<Employees> entitys = DB.Employees.ToList();
                    List<EmployeesDTO> DTO = new List<EmployeesDTO>();
                    foreach (Employees item in entitys)
                    {
                        Mapper.Initialize(cfg => cfg.CreateMap<EmployeesDTO, Employees>());
                        DTO.Add(Mapper.Map<EmployeesDTO>(entitys));
                    }

                    if (DTO != null || DTO.Capacity < 0)
                        return DTO;
                    else
                        return null;
                }
            }
            catch
            {
                return null;
            }
        }

        List<SuppliersDTO> GetSuppliers()
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    //TODO autofax the models to DTO 
                    List<Suppliers> entitys = DB.Suppliers.ToList();
                    List<SuppliersDTO> DTO = new List<SuppliersDTO>();
                    foreach (Suppliers item in entitys)
                    {
                        Mapper.Initialize(cfg => cfg.CreateMap<SuppliersDTO, Employees>());
                        DTO.Add(Mapper.Map<SuppliersDTO>(entitys));
                    }

                    if (DTO != null || DTO.Capacity < 0)
                        return DTO;
                    else
                        return null;
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
