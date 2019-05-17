using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LibDemo.Core.Dto
{
    public class LibraryDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public bool IsAvailable { get; set; }
        public ContactResource Contact { get; set; }
        public ICollection<int> Features { get; set; }

        public LibraryDto()
        {
            Features = new Collection<int>();
        }
    }
}
