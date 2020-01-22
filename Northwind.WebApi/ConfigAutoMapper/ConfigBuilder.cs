using AutoMapper;
using Northwind.DataAccess.Models;
using Nothwind.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.ConfigAutoMapper
{
    public class ConfigBuilder
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
                    .CreateMap<Employees, EmployeesDTO>()
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
