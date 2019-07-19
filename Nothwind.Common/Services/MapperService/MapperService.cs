using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nothwind.Common.Services.MapperService
{
    public class MapperService
    {
        private readonly IMapper _mapper;
        public MapperService(MapperConfiguration config)
        {
            _mapper = config.CreateMapper();
        }
        public TDestic Map<TSource, TDestic>(TSource source)
        {
            return _mapper.Map<TSource, TDestic>(source);
        }
        public TDestic[] Map<TSource, TDestic>(TSource[] source)
        {
            return source.Select(s => Map<TSource, TDestic>(s)).ToArray();
        }
    }
}
