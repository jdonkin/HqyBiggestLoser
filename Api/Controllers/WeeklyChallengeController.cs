using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HqyBiggestLoserApi.Api.Dtos;

namespace HqyBiggestLoserApi.Controllers
{
    [Route("api/[controller]")]
    public class WeeklyChallengeController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<WeeklyChallengeDto> Get()
        {
            var challenge = new WeeklyChallengeDto()
            {
                Week = 2,
                ChallengeId = 3,
                ChallengeName = "Drinking Water"
            };
            var challenges = new List<WeeklyChallengeDto>();
            challenges.Add(challenge);
            
            return challenges;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public WeeklyChallengeDto Get(int id)
        {
            return new WeeklyChallengeDto
            {
                Week = 2,
                ChallengeId = 3,
                ChallengeName = "Drinking Water in bottles"
            };
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]WeeklyChallengeDto challenge)
        {
            return StatusCode(200);
        }
        
    }
}
