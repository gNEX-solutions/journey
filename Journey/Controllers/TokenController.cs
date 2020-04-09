using System.Linq;
using System.Threading.Tasks;
using Journey.Models;
using Journey.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Journey.Controllers
{
   
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly JournyDbContext _journyDb;
        public TokenController(ITokenService tokenService, JournyDbContext journyDb)
        {
            _tokenService = tokenService;
            _journyDb = journyDb;
        }

        //[HttpPost]
        //public async Task<IActionResult> Refresh(string token, string refreshToken)
        //{
        //    var principal = _tokenService.GetPrincipalFromExpiredToken(token);
        //    var username = principal.Identity.Name; //this is mapped to the Name claim by default

        //    var user = _journyDb.Users.SingleOrDefault(u => u.Username == username);
        //    if (user == null || user.RefreshToken != refreshToken) return BadRequest();

        //    var newJwtToken = _tokenService.GenerateAccessToken(principal.Claims);
        //    var newRefreshToken = _tokenService.GenerateRefreshToken();

        //    user.RefreshToken = newRefreshToken;
        //    await _journyDb.SaveChangesAsync();

        //    return new ObjectResult(new
        //    {
        //        token = newJwtToken,
        //        refreshToken = newRefreshToken
        //    });
        //}

        //[HttpPost, Authorize]
        //public async Task<IActionResult> Revoke()
        //{
        //    var username = User.Identity.Name;

        //    var user = _journyDb.Users.SingleOrDefault(u => u.Username == username);
        //    if (user == null) return BadRequest();

        //    user.RefreshToken = null;

        //    await _journyDb.SaveChangesAsync();

        //    return NoContent();
        //}

    }
}