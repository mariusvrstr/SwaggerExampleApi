using SwaggerApi.Common;
using System.Collections.Generic;

namespace SwaggerApi.Models
{
    public class LibraryResults
    {
        public Result Outcome { get; set; }

        public List<Book> Books { get; set; }
    }
}