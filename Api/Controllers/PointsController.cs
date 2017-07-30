using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HqyBiggestLoserApi.Api.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HqyBiggestLoserApi.Controllers
{
    [Route("api/[controller]")]
    public class PointsController : Controller
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]SubmittedPointsDto value)
        {
            return StatusCode(200);
        }
    }
}
