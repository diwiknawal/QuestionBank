using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Server.DataContext;
using QuestionBank.Server.Model;
using SQLitePCL;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace QuestionBank.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly QuestionBankContext _context;

      public  UserController(QuestionBankContext context) {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<User>> ResgisterUser(User user)
        {
            if (user == null)
            {
                return BadRequest("Data validation failed");
            }
            if (await _context.Users.AnyAsync(u => u.Email == user.Email))
            {
                return BadRequest("Username already exists");
            }
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

    }
}
