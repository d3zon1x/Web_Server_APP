using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Server.Core.DTO.CategoryDTO;
using Web_Server.Core.Entity;

namespace Web_Server.Core.Mapper
{
    public class Mapper : AutoMapper.Profile
    {
        public Mapper()
        {
            CreateMap<CategoryDTO, CategoryEntity>().ReverseMap();
            CreateMap<CreateCategoryDTO, CategoryEntity>().ReverseMap();
            CreateMap<EditCategoryDTO, CategoryEntity>().ReverseMap();
        }
    }
}
