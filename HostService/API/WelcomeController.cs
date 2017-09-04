using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HostService.API
{
    [RoutePrefix("api/welcome")]
    public class WelcomeController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to WebAPI hosted in Windows Service";
        }

        [Route("detail")]
        public IEnumerable<string> GetMultiple()
        {
            return new string[] { "Welcome1", "Welcome2", "Welcome3" };
        }
    }
}
