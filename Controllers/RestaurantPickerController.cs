using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EightToTen.Service.Restaurant;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly IRestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController(IRestaurantPickerService RestaurantPickerService)
        {
            _restaurantPickerService = RestaurantPickerService;
        }

        [HttpGet ("RestaurantPicker/{A) Korean BBQ}/{B) Japanese Food}/ {c) Mexican Food}")]

        public string AddRestaurant(string userChoi)
        {
            return _restaurantPickerService.AddRestaurant(userChoi);
        }

        [HttpGet ("JustKorean/{ YesOrNo}")]

        public string AddKorean( string YesOrNo)
        {
            return "";
        }

        [HttpGet ("JustJapanese/{ YesOrNo }")]

        public string AddJap(string YesOrNo)
        {
            return "";
        }

        [HttpGet ("JustMexican/{ YesOrNo }")]

        public string AddMexican(string YesOrNo)
        {
            return "";
        }
    }
}