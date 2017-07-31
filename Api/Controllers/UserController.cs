using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HqyBiggestLoserApi.Api.Dtos;

namespace HqyBiggestLoserApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<UserDto> Get()
        {
            var user = new UserDto()
            {
                UsersFirstName = "Eric",
                UsersLastName = "Bana",
                UsersTeamName = "TeamHulk",
                InitialWeight = 150m
            };

            var users = new List<UserDto>();
            users.Add(user);
            return users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public UserDto Get(int id)
        {
            return new UserDto()
            {
                UsersFirstName = "Tim",
                UsersLastName = "Tiny",
                UsersTeamName = "Scrooge",
                InitialWeight = 75m
            };
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]UserDto value)
        {
            return StatusCode(200);
        }
    }
}
