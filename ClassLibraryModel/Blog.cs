using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class Blog
    {
        public Guid BlogID { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ImageURL { get; set; }
    }
}
