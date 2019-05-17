using AutoMapper;
using LibDemo.Core.Dto;
using LibDemo.Core.Models;
using LibDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibDemo.Controllers
{
    [Route("/api/[controller]")]
    public class LibrariesController:ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public LibrariesController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLibrary([FromBody] LibraryDto libraryDto)
        {
            var library = mapper.Map<LibraryDto, Library>(libraryDto);
            library.LastUpdate = DateTime.Now;
            context.Libraries.Add(library);
            await context.SaveChangesAsync();
            var result = mapper.Map<Library, LibraryDto>(library);
            return Ok(result);
        }
    }
}
