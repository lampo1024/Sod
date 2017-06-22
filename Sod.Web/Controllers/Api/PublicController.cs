using System;
using System.Linq;
using System.Web.Http;
using Sod.Services;
using Sod.Web.Extensions;

namespace Sod.Web.Controllers
{
    public class PublicController : ApiController
    {
        private readonly IPersonService _personService;
        public PublicController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet]
        public IHttpActionResult Find()
        {
            var model = _personService.FindAll().Select(x=>x.ToViewModel());
            return Ok(model);
        }

        [HttpGet]
        public IHttpActionResult Ex()
        {
            throw  new ArgumentNullException();
        }
    }
}
