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
    class EmployeesAccess : IEmployeesAccess
    {
        static NorthwindMapperConfigBuilder ConfigBuilder;
        EmployeesDTO[] GetEmployees()
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    var employees = DB.Employees.ToArray();
                    MapperService mapper = new MapperService(ConfigBuilder.GetConfiguration());
                    var items = mapper.Map<Employees, EmployeesDTO>(employees);
                    return items;
                }
            }
            catch
            {
                return null; 
            }
        }
        bool IEmployeesAccess.EmployeesAdd(EmployeesDTO DTO)
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    MapperService mapper = new MapperService(ConfigBuilder.GetConfiguration());
                    var item = mapper.Map<EmployeesDTO, Employees>(DTO);

                    DB.Add(item);
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
        public MapperConfiguration GetConfiguration()
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
                    .ForMember(m => m.Title, o => o.MapFrom(d => d.Title))
                    .ForMember(m => m.TitleOfCourtesy, o => o.MapFrom(d => d.TitleOfCourtesy))
                    .ForMember(m => m.Region, o => o.MapFrom(d => d.Region))
                    .ForMember(m => m.PostalCode, o => o.MapFrom(d => d.PostalCode))
                    .ForMember(m => m.HomePhone, o => o.MapFrom(d => d.HomePhone))
                    .ForMember(m => m.ReportsTo, o => o.MapFrom(d => d.ReportsTo))
                    .ForMember(m => m.Notes, o => o.MapFrom(d => d.Notes))
                    .ForMember(m => m.HireDate, o => o.MapFrom(d => d.HireDate));
                config
                    .CreateMap<Employees,EmployeesDTO>()
                    .ForMember(m => m.EmployeeId, o => o.MapFrom(d => d.EmployeeId))
                    .ForMember(m => m.FirstName, o => o.MapFrom(d => d.FirstName))
                    .ForMember(m => m.LastName, o => o.MapFrom(d => d.LastName))
                    .ForMember(m => m.DoB, o => o.MapFrom(d => d.BirthDate))
                    .ForMember(m => m.Address, o => o.MapFrom(d => d.Address))
                    .ForMember(m => m.Country, o => o.MapFrom(d => d.Country))
                    .ForMember(m => m.City, o => o.MapFrom(d => d.City))
                    .ForMember(m => m.Title, o => o.MapFrom(d => d.Title))
                    .ForMember(m => m.TitleOfCourtesy, o => o.MapFrom(d => d.TitleOfCourtesy))
                    .ForMember(m => m.Region, o => o.MapFrom(d => d.Region))
                    .ForMember(m => m.PostalCode, o => o.MapFrom(d => d.PostalCode))
                    .ForMember(m => m.HomePhone, o => o.MapFrom(d => d.HomePhone))
                    .ForMember(m => m.ReportsTo, o => o.MapFrom(d => d.ReportsTo))
                    .ForMember(m => m.Notes, o => o.MapFrom(d => d.Notes))
                    .ForMember(m => m.HireDate, o => o.MapFrom(d => d.HireDate));
                ;
            });
        }
    }
}
