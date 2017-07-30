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
    public class TeamPointsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<TeamPointsDto> Get()
        {
            var team = new TeamPointsDto
            {
                TeamName = "TeamAwesome",
                Points = 200m,
                Week = 12
            };
            var teams = new List<TeamPointsDto>();
            teams.Add(team);

            return teams;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TeamPointsDto Get(string teamName)
        {
            return new TeamPointsDto
            {
                TeamName = teamName,
                Points = 120,
                Week = 2
            };
        }
    }
}
