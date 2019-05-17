using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibDemo.Core.Models
{
    public class LibraryFeature
    {
        public int LibraryId { get; set; }
        public int FeatureId { get; set; }
        public Library Library { get; set; }
        public Feature Feature { get; set; }
    }
}
