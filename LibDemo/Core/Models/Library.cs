using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LibDemo.Core.Models
{
    public class Library
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public bool IsAvailable { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<LibraryFeature> Features { get; set; }

        public Library()
        {
            Features = new Collection<LibraryFeature>();
        }
    }
}
