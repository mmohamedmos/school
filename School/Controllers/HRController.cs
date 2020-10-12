using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using School.IServices;
using School.Models;
using School.Repositry;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HRController : ControllerBase
    {
        public IHrService HrService { get; }

        public HRController(IHrService hrService  )
        {
            HrService = hrService;
        }
        [HttpPost]
        public IActionResult Register([FromBody] HR value)
        {
            HR hr = HrService.Register(value);
            if (hr == null)
            {
                return StatusCode(400);
            }
            return StatusCode(201);

        }
        [HttpPost("LoginHr")]
        public IActionResult LoginHr([FromBody]HR hr)
        {
            HR hrcheck = HrService.LoginHr(hr);
            if (hrcheck == null)
            {
                return StatusCode(201);
            }
            return Ok(hrcheck);
        }
        //public IActionResult LoginHr([FromBody]HR User)
        //{
        //    //var UserFromRepo = Login.Login(User.Name, User.Password);
        //    //if (UserFromRepo == null) { return Unauthorized(); }
        //    //var clamis = new[]{
        //    //  new Claim(ClaimTypes.NameIdentifier,UserFromRepo.id.ToString()),
        //    //  new Claim(ClaimTypes.Name,UserFromRepo.Name)
        //    //};
        //    //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("AppSettings:Token").Value));
        //    //var creds = new SigningCredentials(key, SecurityAlgorithms.RsaSsaPssSha512Signature);
        //    //var tokenDiscribtor = new SecurityTokenDescriptor
        //    //{
        //    //    Subject = new ClaimsIdentity(clamis),
        //    //    Expires = DateTime.Now.AddDays(1),
        //    //    SigningCredentials = creds
        //    //};
        //    //var tokenhandller = new JwtSecurityTokenHandler();
        //    //var token = tokenhandller.CreateToken(tokenDiscribtor);
        //    //return Ok(new { token = tokenhandller.WriteToken(token) });

        //    return null;
        //}
    }    
    
    }