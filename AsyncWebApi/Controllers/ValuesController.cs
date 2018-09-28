using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AsyncWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("sync")]
        public IActionResult SyncGet()
        {
            Thread.Sleep(3000);
            return Ok();
        }

        // GET api/values/5
        [HttpGet("async")]
        public async Task<IActionResult> AsyncGet()
        {
            await Task.Run(()=>Thread.Sleep(3000));
            return Ok();
        }
    }
}
