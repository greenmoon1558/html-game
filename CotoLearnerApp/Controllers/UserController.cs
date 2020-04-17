using System.Threading.Tasks;
using CotoLearnerApp.Data;
using CotoLearnerApp.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly CotoLearnerContext _db;
    private readonly UserManager<AppUser> _userManager;
    public UsersController(CotoLearnerContext db, UserManager<AppUser> userManager)
    {
        _db = db;
        _userManager = userManager;
    }
    [HttpGet]
    public async Task<IActionResult> GetUser()
    {
        if(_userManager.FindByEmailAsync("abc@gmail.com").GetAwaiter().GetResult() == null)
        {
            var user = new AppUser
            {
                FirstName = "abc",
                LastName = "def",
                UserName = "abc@gmail.com",
                Email = "abc@gmail.com",
                EmailConfirmed = true,
                LockoutEnabled = false 
            };
            _userManager.CreateAsync(user,"Abc@123").GetAwaiter().GetResult();
        }
        return Ok(await _db.Users.ToListAsync());
    }
}