using AutoMapper;
using LinBilgisayarAuthServer.Core.Dtos;
using LinBilgisayarAuthServer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarAuthServer.Service
{
    public class  DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();

        }
    }
}
