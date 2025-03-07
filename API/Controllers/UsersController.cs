using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(DataContext context) : ControllerBase
    {

        [HttpGet]
        //when u return a type of ActionResult, u can return Http responses such as 
        // OK(), BadRequest(), NotFound() etc
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            // return BadRequest("This is an error message");
            // return NotFound;
            return Ok(users);
        }

        [HttpGet("{id:int}")] // /api/users/1    -> u can add type safety :int
        public async Task<ActionResult<AppUser>> GetUsersById(int id)
        {
            var user = await context.Users.FindAsync(id);
            if(user is null) return NotFound();
            return user;
        }
    }
}
