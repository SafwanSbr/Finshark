using api.DTOs;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        public AccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager; 
        }

        [HttpPost("register")]
        public async Task<IActionResult> Registration([FromBody] RegisterDTO regDTO)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var appUser = new AppUser
                {
                    UserName = regDTO.Username,
                    Email = regDTO.Email
                };

                var createUser = await _userManager.CreateAsync(appUser, regDTO.Password);
                if (createUser.Succeeded) 
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
                    if(roleResult.Succeeded)
                    {
                        return Ok("User Created");
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }

                }
                else
                {
                    return StatusCode(500, createUser.Errors);
                }
            } catch (Exception ex) { return StatusCode(500, ex); }
        }
    }
}
