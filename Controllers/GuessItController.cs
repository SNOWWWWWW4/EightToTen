using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EightToTen.Service.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly IGuessItService _guessItService;

        public GuessItController(IGuessItService GuessItService)
        {
            _guessItService = GuessItService;
        }
        [HttpGet ("GuessIt/{EasyMode}")]

        public string EasyMode(string userChoi)
        {
            return _guessItService.EasyMode(userChoi);
        }

        [HttpGet ("GuessIt/{MediumMode}")]

        public string MediumMode(string userChoi)
        {
            return _guessItService.MediumMode(userChoi);
        }

        [HttpGet ("GeussIt/{HardMode}")]
        public string HardMode(string userChoi)
        {
            return _guessItService.HardMode(userChoi);
        }
    }
}