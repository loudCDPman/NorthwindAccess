using AutoMapper;
using Northwind.DataAccess.Models;
using Nothwind.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nothwind.Common.Services.MapperService;

namespace Northwind.DataAccess
{
    class EmployeesAccess
    {
        //static NorthwindMapperConfigBuilder ConfigBuilder;
        //EmployeesDTO[] GetEmployees()
        //{
        //    try
        //    {
        //        using (NorthwindContext DB = new NorthwindContext())
        //        {
        //            var employees = DB.Employees.ToArray();
        //            MapperService mapper = new MapperService(ConfigBuilder.GetConfiguration());
        //            var items = mapper.Map<Employees, EmployeesDTO>(employees);
        //            return items;
        //        }
        //    }
        //    catch
        //    {
        //        return null; 
        //    }
        //}
        //bool EmployeesAdd(EmployeesDTO DTO)
        //{
        //    try
        //    {
        //        using (NorthwindContext DB = new NorthwindContext())
        //        {
        //            MapperService mapper = new MapperService(ConfigBuilder.GetConfiguration());
        //            var item = mapper.Map<EmployeesDTO, Employees>(DTO);
        //            DB.Add(item);
        //            DB.SaveChanges();
        //            return true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        //bool EmployeesRemove(EmployeesDTO DTO)
        //{
        //    try
        //    {
        //        using (NorthwindContext DB = new NorthwindContext())
        //        {
        //            MapperService mapper = new MapperService(ConfigBuilder.GetConfiguration());
        //            var item = mapper.Map<EmployeesDTO, Employees>(DTO);
        //            DB.Remove(item);
        //            DB.SaveChanges();
        //            return true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //bool EmployeesMod(EmployeesDTO DTO)
        //{
        //    try
        //    {
        //        using (NorthwindContext DB = new NorthwindContext())
        //        {
        //            //TODO fix
        //            MapperService mapper = new MapperService(ConfigBuilder.GetConfiguration());
        //            var model = mapper.Map<EmployeesDTO, Employees>(DTO);

        //            var item = DB.Employees.Where(b => b.EmployeeId == DTO.EmployeeId);
        //            if (item != null)
        //            {
        //                DB.Add(model);
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //            DB.SaveChanges();
        //            return true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
    //class MapperService
    //{
    //    private readonly IMapper _mapper;
    //    public MapperService(MapperConfiguration config)
    //    {
    //        _mapper = config.CreateMapper();
    //    }
    //    public TDestic Map<TSource, TDestic>(TSource source)
    //    {
    //        return _mapper.Map<TSource, TDestic>(source);
    //    }
    //    public TDestic[] Map<TSource, TDestic>(TSource[] source)
    //    {
    //        return source.Select(s => Map<TSource,TDestic>(s)).ToArray();
    //    }
    //}
    public class NorthwindMapperConfigBuilder
    {
       
    }
}
