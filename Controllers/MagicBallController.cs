using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EightToTen.Service.MagicBall;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MagicBallController : ControllerBase
    {
        private readonly IMagicBallService _magicBallService;

        public MagicBallController(IMagicBallService MagicBallService)
        {
            _magicBallService = MagicBallService;
        }

        [HttpGet ("Magic8Ball/{input}")]
        public string MagicBall(string input)
        {
            return _magicBallService.MagicBall(input);
        }
    }
}