using Northwind.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Nothwind.Common;
using AutoMapper;


namespace Northwind.DataAccess
{
    public class TerritoresAccess
    {

        public bool TerritoriesAdd(TerritoriesDTO DTO)
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<TerritoriesDTO, Territories>());
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
        public bool TerritoriesRemove(TerritoriesDTO DTO)
        {
            try
            {
                using (NorthwindContext DB = new NorthwindContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<TerritoriesDTO, Territories>());
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

    }
}
