using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Сайт
{
    [Route("/[controller]")]
    [ApiController]
    public class CookieController : ControllerBase
    {
        [HttpPost]
        public async Task <ActionResult> Login([FromForm] string name)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(new List<Claim> 
            {
            new Claim(ClaimTypes.NameIdentifier, name)
            }, "auth");
            ClaimsPrincipal claims = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claims);
            return Redirect("/");
        } 
    }
}
