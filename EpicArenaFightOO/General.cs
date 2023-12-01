using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicArenaBattleOO
{
    static class General
    {
        //generates random number between 1 and 10 - for archer versus knigth fight and hero type selection
        public static int GenerateRandom(int i)
        {
            Random rnd = new Random();
            return rnd.Next(1, i+1);
        }
        public static void LogEvents(string line)
        {
            Console.WriteLine(line);
        }
    }
}
