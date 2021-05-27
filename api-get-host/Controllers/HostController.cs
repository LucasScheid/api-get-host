using Microsoft.AspNetCore.Mvc;
using System;

namespace api_get_host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HostController
    {
        [HttpGet]
        public string Get()
        {
            return string.Concat(Environment.MachineName);
        }
    }
}
