using AutoMapper;
using LibDemo.Core.Dto;
using LibDemo.Core.Models;
using LibDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibDemo.Controllers
{
    [Route("/api/[controller]")]
    public class AuthorsController: ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public AuthorsController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AuthorDto>> GetAuthors()
        {
            var authors = await context.Authors.Include(x => x.Books).ToListAsync();
            return mapper.Map<List<Author>, List<AuthorDto>>(authors);         
        }
    }
}
