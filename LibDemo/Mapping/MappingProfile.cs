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
            CreateMap<Library, LibraryDto>().ForMember(ld => ld.Contact,
                opt => opt.MapFrom(l => new ContactResource { Name = l.ContactName, Email = l.ContactEmail, Phone = l.ContactPhone }))
                .ForMember(ld => ld.Features, opt => opt.MapFrom(l => l.Features.Select(ld => ld.FeatureId)));


            //api to domain
            CreateMap<LibraryDto, Library>().ForMember(l => l.ContactName, opt => opt.MapFrom(x => x.Contact.Name))
                                            .ForMember(l => l.ContactEmail, opt => opt.MapFrom(x => x.Contact.Email))
                                            .ForMember(l => l.ContactPhone, opt => opt.MapFrom(x => x.Contact.Phone))
                                            .ForMember(l => l.Features, opt => 
                                                opt.MapFrom(ld => ld.Features.Select(id => new LibraryFeature { FeatureId = id})));
        }
    }
}
