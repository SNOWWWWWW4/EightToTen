using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Service.GuessIt
{
    public interface IGuessItService
    {
        string EasyMode(string userChoi);
        string MediumMode(string userChoi);
        string HardMode(string userChoi);
    }
}