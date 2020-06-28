using System;
using System.Collections.Generic;

namespace SwaggerApi.Common
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<BookFormat> AvailableFormats { get; set; }
    }
}