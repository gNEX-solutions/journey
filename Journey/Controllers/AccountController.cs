using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Journey.Models;
using Journey.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Journey.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JournyDbContext _journyDb;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenService _tokenService;
        private readonly ILogger<AccountController> _logger;
        public AccountController( JournyDbContext journyDb, IPasswordHasher passwordHasher, ITokenService tokenService, ILogger<AccountController> logger)
        {
            _journyDb = journyDb;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
            _logger = logger;

            _logger.LogDebug(1, "NLog injected into AccountController");
        }
        [HttpPost("api/signup")]
        public async Task<IActionResult> Signup([FromBody]User userDto)
        {

            try {


                var user = _journyDb.Users.SingleOrDefault(u => u.Username == userDto.Username);
                if (user != null)  return BadRequest(new { message = "Username Alredy Taken" });

             _journyDb.Users.Add(new User
                {
                    Username = userDto.Username,
                    Password = _passwordHasher.GenerateIdentityV3Hash(userDto.Password)
                });


                await _journyDb.SaveChangesAsync();

                return Ok(new { message = "User Created Succesfully"}) ;

            } catch (Exception e) { 
                _logger.LogError(2,e.Message,"");
                return BadRequest(e.Message);
            }
           
        }

        [HttpPost("api/login")]
        public async Task<IActionResult> Login([FromBody]User userDto)
        {
            var user = _journyDb.Users.SingleOrDefault(u => u.Username == userDto.Username);
            if (user == null || !_passwordHasher.VerifyIdentityV3Hash(userDto.Password, user.Password)) return BadRequest();

            var usersClaims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString())
            };

            var jwtToken = _tokenService.GenerateAccessToken(usersClaims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            await _journyDb.SaveChangesAsync();

            return new ObjectResult(new
            {
                token = jwtToken,
                refreshToken = refreshToken
            });
        }
    }
}