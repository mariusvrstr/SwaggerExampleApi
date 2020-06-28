using SwaggerApi.Common;
using SwaggerApi.Models;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace SwaggerApi.Controllers
{
    [RoutePrefix("api/library/v1")] 

    public class LibraryController : ApiController
    {
        BookRepositoryStub repo;

        public LibraryController()
        {
            repo = new BookRepositoryStub();
        }

        [AcceptVerbs("GET")]
        [AllowAnonymous]
        [Route("echoTest")]
        public string EchoTest(string echoValue)
        {
            return string.Format($"You have successfully done the [{this.GetType().Name}] echo test >> {echoValue}");
        }

        [AcceptVerbs("POST")]
        [Route("searchLibrary")]
        [AllowAnonymous]
        [ResponseType(typeof(LibraryResults))]
        public LibraryResults SearchLibrary(SearchLibraryRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.TitleName))
                {
                    return new LibraryResults()
                    {
                        Outcome = Result.Success,
                        Books = repo.FindAll().ToList()
                    };
                }

                return new LibraryResults()
                {
                    Outcome = Result.Success,
                    Books = repo.FindByTitle(request.TitleName).ToList()
                };
            }
            catch (Exception ex)
            {
                // Log the errror

                return new LibraryResults
                {
                    Outcome = Result.Failed
                };
            }
        }

    }
}
