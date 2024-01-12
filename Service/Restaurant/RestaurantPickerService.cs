using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Service.Restaurant
{
    public class RestaurantPickerService : IRestaurantPickerService
    {
        public string AddJap(string YesOrNo)
        {
            if(YesOrNo == "Yes"){
                
                Random randClass = new Random();
                int picked = randClass.Next(0,10);

                string[] katsuPLace = new string [10];
                katsuPLace[0] = "Ramen 101";
                katsuPLace[1] = "Kyotp Shushi Bar Grill & Ramen";
                katsuPLace[2] = "Blue Nami";
                katsuPLace[3] = "Satori Sushi & Teriyaki Grill";
                katsuPLace[4] = "Ono Hawaiian BBQ";
                katsuPLace[5] = "L&L Hawaiian Barbecue";
                katsuPLace[6] = "Bento Box";
                katsuPLace[7] = "Ju Hachi";
                katsuPLace[8] = "Akebono";
                katsuPLace[9] = "Fujiya";

                return $"\nCheck out {katsuPLace[picked]}";

            }else if (YesOrNo == "No"){
                return "Alright, come by soon!";
            }else{
                return "Please enter Yes or enter No";
            }
            
        }


        public string AddKorean(string YesOrNo)
        {
             if(YesOrNo == "Yes"){
                Random randClass = new Random();
                int picked = randClass.Next(0,10);

                string[] bbqPlace = new string[10];
                bbqPlace[0] = "Blue House Korean BBQ";
                bbqPlace[1] = "Oz Korean BBQ";
                bbqPlace[2] = "JJ Korean BBQ";
                bbqPlace[3] = "Heat Shabu Baru";
                bbqPlace[4] = "GoGi Korean BBQ & Hot Pot";
                bbqPlace[5] = "Hanu Korean BBQ";
                bbqPlace[6] = "Soowon Galbi KBBQ Restaurant";
                bbqPlace[7] = "Gangnam station Korean BBQ";
                bbqPlace[8] = "Gen Korean BBQ House";
                bbqPlace[9] = "Daikon Korean BBQ";

                return $"Consider visiting {bbqPlace[picked]} ";

            }else if (YesOrNo == "No"){
                return "Alright, come by soon!";
            }else{
                return "Please enter Yes or enter No";
            }

            
        }

        public string AddMexican(string YesOrNo)
        {
             if(YesOrNo == "Yes"){
                
                Random randClass = new Random();
                int picked = randClass.Next(0,10);

                string [] tacoPlace =  new string [10];
                tacoPlace[0] = "Kogi food truck";
                tacoPlace[1] = "El Comal food truck";
                tacoPlace[2] = "Taqueria El farolito";
                tacoPlace[3] = "La Santaneca De La Mission";
                tacoPlace[4] = "Lorenzo's";
                tacoPlace[5] = "Carmelita's Mexian Restaurant";
                tacoPlace[6] = "Mezcalito Oaxacan Cuisine";
                tacoPlace[7] = "Don Quixote's Mexican Grill";
                tacoPlace[8] = "Azul Mexican Food + Tequila bar";
                tacoPlace[9] = "Rey Azteca estuarant & Bar";
                
                return $"Mexican food! Consider eating at {tacoPlace[picked]}";

            }else if (YesOrNo == "No"){
                return "Alright, come by soon!";
            }else{
                return "Please enter Yes or enter No";
            }
            

        }

        public string AddRestaurant(string userChoi)
        {
            Random randClass = new Random();
            int picked = randClass.Next(0,10);

            if(userChoi == "korean bbq" || userChoi =="a"){
                
                string[] bbqPlace = new string[10];
                bbqPlace[0] = "Blue House Korean BBQ";
                bbqPlace[1] = "Oz Korean BBQ";
                bbqPlace[2] = "JJ Korean BBQ";
                bbqPlace[3] = "Heat Shabu Baru";
                bbqPlace[4] = "GoGi Korean BBQ & Hot Pot";
                bbqPlace[5] = "Hanu Korean BBQ";
                bbqPlace[6] = "Soowon Galbi KBBQ Restaurant";
                bbqPlace[7] = "Gangnam station Korean BBQ";
                bbqPlace[8] = "Gen Korean BBQ House";
                bbqPlace[9] = "Daikon Korean BBQ";

                return $"\nKorean BBQ? Splendind choice! Consider visiting {bbqPlace[picked]} ";

            }else if(userChoi == "japanese food" || userChoi == "b"){

                string[] katsuPLace = new string [10];
                katsuPLace[0] = "Ramen 101";
                katsuPLace[1] = "Kyotp Shushi Bar Grill & Ramen";
                katsuPLace[2] = "Blue Nami";
                katsuPLace[3] = "Satori Sushi & Teriyaki Grill";
                katsuPLace[4] = "Ono Hawaiian BBQ";
                katsuPLace[5] = "L&L Hawaiian Barbecue";
                katsuPLace[6] = "Bento Box";
                katsuPLace[7] = "Ju Hachi";
                katsuPLace[8] = "Akebono";
                katsuPLace[9] = "Fujiya";

                return $"\nJapanese Food! You should check out {katsuPLace[picked]}";
                

            }else if(userChoi == "mexican food" || userChoi == "c"){

                string [] tacoPlace =  new string [10];
                tacoPlace[0] = "Kogi food truck";
                tacoPlace[1] = "El Comal food truck";
                tacoPlace[2] = "Taqueria El farolito";
                tacoPlace[3] = "La Santaneca De La Mission";
                tacoPlace[4] = "Lorenzo's";
                tacoPlace[5] = "Carmelita's Mexian Restaurant";
                tacoPlace[6] = "Mezcalito Oaxacan Cuisine";
                tacoPlace[7] = "Don Quixote's Mexican Grill";
                tacoPlace[8] = "Azul Mexican Food + Tequila bar";
                tacoPlace[9] = "Rey Azteca estuarant & Bar";
                
                return $"Mexican food! Consider eating at {tacoPlace[picked]}";
                

            }else{
                
                return "Sorry that is not an option. Please enter one of the following \n A or Korean BBQ \n B or Japanese food \n C or Mexican food \n ";
                
            }
        }
    }
}