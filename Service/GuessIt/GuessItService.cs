using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Service.GuessIt
{
    public class GuessItService : IGuessItService
    {
        Random randClass = new Random();
        public string EasyMode(string userChoi)
        {
            int num;
            int picked = randClass.Next(1,11);
            bool success = Int32.TryParse(userChoi,out num);
                
            if(success)
            {
                if(num > picked)
                {
                    return $"{userChoi} is greater than the random number: {picked}";
                    
                }else if(num < picked)
                {
                    return $"{userChoi} is greater than the random number: {picked}";
                }else{
                    return $"Congrats both numbers are equal to each other!";
                }

            }else{
                return "Please enter a whole number 1-10";
            }
            
        }

        public string HardMode(string userChoi)
        {
            int num;
            int picked = randClass.Next(1,101);
            bool success = Int32.TryParse(userChoi,out num);
                
            if(success)
            {
                if(num > picked)
                {
                    return $"{userChoi} is greater than the random number: {picked}";
                    
                }else if(num < picked)
                {
                    return $"{userChoi} is greater than the random number: {picked}";
                }else{
                    return $"Congrats both numbers are equal to each other!";
                }

            }else{
                return "Please enter a whole number 1-10";
            }
            
        }

        public string MediumMode(string userChoi)
        {
            int num;
            int picked = randClass.Next(1,51);
            bool success = Int32.TryParse(userChoi,out num);
                
            if(success)
            {
                if(num > picked)
                {
                    return $"{userChoi} is greater than the random number: {picked}";
                    
                }else if(num < picked)
                {
                    return $"{userChoi} is greater than the random number: {picked}";
                }else{
                    return $"Congrats both numbers are equal to each other!";
                }

            }else{
                return "Please enter a whole number 1-10";
            }
            
        }
    }
}