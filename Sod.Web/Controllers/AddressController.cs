using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using Sod.Services;
using Sod.Web.Extensions;

namespace Sod.Web.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        // GET: Address
        public ContentResult Index()
        {
            var list = _addressService.FindAllAddressWithPersonNames().Select(x=>x.ToViewModel());
            return new ContentResult
            {
                Content=JsonConvert.SerializeObject(list)
            };
        }
    }
}