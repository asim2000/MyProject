using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private IAuthService _authService;

        public HomeController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet("getmessage")]
        public string GetMessage()
        {
            return "Hello";
        }
    }
}
