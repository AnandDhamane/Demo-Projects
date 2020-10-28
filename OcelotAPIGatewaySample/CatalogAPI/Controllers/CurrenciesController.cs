using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase {
        [HttpGet, Route("")]
        [Authorize(Policy = "PublicSecure")]
        public ActionResult<IEnumerable<string>> Get() {
            return new string[] { "USD", "INR", "EURO" };
        }
    }
}
