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
    public class UserPointsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<UserPointsDto> Get()
        {
            var user = new UserPointsDto
            {
                UserName = "Awesome",
                PointsAmount = 200m,
                Week = 12
            };
            var users = new List<UserPointsDto>();
            users.Add(user);

            return users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public UserPointsDto Get(string userName)
        {
            return new UserPointsDto
            {
                UserName = userName,
                PointsAmount = 120m,
                Week = 2
            };
        }
    }
}
