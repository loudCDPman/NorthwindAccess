using AutoMapper;
using Northwind.DataAccess.Models;
using Nothwind.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.DataAccess
{
    class EmployeesAccess : IEmployeesAccess
    {

        EmployeesDTO[] GetEmployees()
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    var employees = DB.Employees;

                }
            }
            catch
            {
                return null; 
            }
            return null;
        }
        bool IEmployeesAccess.EmployeesAdd(EmployeesDTO DTO)
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<EmployeesDTO, Territories>());
                    var model = Mapper.Map<Territories>(DTO);
                    DB.Add(model);
                    DB.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        bool IEmployeesAccess.EmployeesRemove(EmployeesDTO DTO)
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<EmployeesDTO, Territories>());
                    var model = Mapper.Map<Territories>(DTO);
                    DB.Remove(model);
                    DB.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        bool IEmployeesAccess.EmployeesMod(EmployeesDTO DTO)
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    //TODO fix
                    Mapper.Initialize(cfg => cfg.CreateMap<EmployeesDTO, Territories>());
                    var model = Mapper.Map<Territories>(DTO);
                    var item = DB.Employees.Where(b => b.EmployeeId == DTO.EmployeeId);
                    if (item != null)
                    {
                        DB.Add(model);
                    }
                    else
                    {
                        return false;
                    }

                    DB.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
    class MapperService
    {
        private readonly IMapper _mapper;
        public MapperService(MapperConfiguration config)
        {
            _mapper = config.CreateMapper();
        }
        TDestic Map<TSource, TDestic>(TSource source)
        {
            return _mapper.Map<TSource, TDestic>(source);
        }
        TDestic[] Map<TSource, TDestic>(TSource[] source)
        {
            return source.Select(s => Map<TSource,TDestic>(s)).ToArray();
        }
    }
    public class NorthwindMapperConfigBuilder
    {
        MapperConfiguration GetConfiguration()
        {
            return new MapperConfiguration(config =>
            {
                config
                    .CreateMap<EmployeesDTO, Employees>()
                    .ForMember(m => m.EmployeeId, o => o.MapFrom(d => d.EmployeeId))
                    .ForMember(m => m.FirstName, o => o.MapFrom(d => d.FirstName))
                    .ForMember(m => m.LastName, o => o.MapFrom(d => d.LastName))
                    .ForMember(m => m.BirthDate, o => o.MapFrom(d => d.DoB))
                    .ForMember(m => m.Address, o => o.MapFrom(d => d.Address))
                    .ForMember(m => m.Country, o => o.MapFrom(d => d.Country))
                    .ForMember(m => m.City, o => o.MapFrom(d => d.City))
            // .ForMember(m => m.EmployeeTerritories, o => o.MapFrom(d => d.))



            ;
            });
        }
    }
}
