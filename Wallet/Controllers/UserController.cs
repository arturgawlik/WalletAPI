using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Commands.Users;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Wallet.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var users = await userService.GetAllUsers();

            return Json(users);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CreateUser user)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody]CreateUser command)
        {
            await userService.RegisterUserAsync(command.Username, command.Password);

            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}