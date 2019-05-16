using AutoMapper;
using LibDemo.Core.Dto;
using LibDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibDemo.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {

            //domain to api
            CreateMap<Author, AuthorDto>();
            CreateMap<Book, BookDto>();


            //api to domain
        }
    }
}
