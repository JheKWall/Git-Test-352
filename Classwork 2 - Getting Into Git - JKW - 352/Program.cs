using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2___Getting_Into_Git___JKW___352
{
    class Program
    {
        public int generateRandomInt()
        {
            // Instantiating Random Num. Generator
            Random rand = new Random();

            // Return Random Number Between 0-100
            return rand.Next(0, 100);
        }

        public int userNumStatus()
        {

        }

        public int NumGuesses = 0;
        public int RandNum;
        public int UserNum;

        public bool IsRight = false;

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Guess a number from 0-100... NOW:\n");
            Console.Read();

            while(!p.IsRight)
            {

            }
        }
    }
}
