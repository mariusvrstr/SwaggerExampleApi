using SwaggerApi.Common;

namespace SwaggerApi.Models
{
    public class SearchLibraryRequest
    {
        public string TitleName { get; set; }

        public BookFormat BookFormat { get; set; }
    }
}