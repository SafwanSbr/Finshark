using api.DTOs;
using api.Interfaces;
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
        private readonly ITokenService _tokenService;
        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService)
        {
            _tokenService = tokenService;
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
                        return Ok(new NewUserDTO
                        {
                            UserName = appUser.UserName,
                            Email = appUser.Email,
                            Token = _tokenService.CreateToken(appUser)
                        });
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
