using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Service.Restaurant
{
    public interface IRestaurantPickerService
    {
        string AddRestaurant(string userChoi);

        string AddKorean( string YesOrNo);
        string AddJap(string YesOrNo);
        string AddMexican(string YesOrNo);
    }
}