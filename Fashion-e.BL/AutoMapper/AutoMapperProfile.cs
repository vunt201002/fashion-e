using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.DTOs.Category;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.BL.AutoMapper
{
    /// <summary>
    /// map giữa entity và dto
    /// </summary>
    /// created by: ntvu (20/11/2023)
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CategoryDTO, Category>();
        }
    }
}
