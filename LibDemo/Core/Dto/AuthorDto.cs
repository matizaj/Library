using LibDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LibDemo.Core.Dto
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<BookDto> Books { get; set; }
        public AuthorDto()
        {
            Books = new Collection<BookDto>();
        }
    }
}
