using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2___Getting_Into_Git___JKW___352
{
    class Program
    {
        //Method for generating a random integer value
        public void generateRandomInt()
        {
            // Instantiating Random Num. Generator
            Random rand = new Random();

            // Return Random Number Between 0-100
            RandNum = rand.Next(0, 100);
        }

        //Informs user if their guess is higher, lower, or is right
        public void userNumStatus()
        {
            // If Correct
            if (UserNum == RandNum)
            {
                Console.WriteLine("I think that's the right number, let me check. . .\n");
                IsRight = true;
            }

            // If Lower
            if (UserNum < RandNum)
            {
                Console.WriteLine("A bit higher than that!\n");
            }

            // If Higher

            if (UserNum > RandNum)
            {
                Console.WriteLine("A bit lower than that!\n");
            }

            NumGuesses++;
        }

        //UserNum Accessor
        public int getUserNum()
        {
            return UserNum;
        }

        public int NumGuesses = 0;
        public int RandNum;
        public int UserNum;

        public bool IsRight = false;

        static void Main(string[] args)
        {
            //Program thingy
            Program p = new Program();

            //Generate Random Num
            p.generateRandomInt();

            //Prompt user for an input
            Console.WriteLine("Guess a number from 0-100... Only number inputs are allowed, dont you dare try anything else!\n");
            p.UserNum = Convert.ToInt32(Console.ReadLine());

            //Loops prompt if the user hasn't guessed the right number
            while(!p.IsRight)
            {
                p.userNumStatus();
                if (!p.IsRight)
                {
                    p.UserNum = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Exit Prompt
            Console.WriteLine("Yea that's the right answer, good job!\n");
            Console.WriteLine("That took you " + p.NumGuesses + " guesses... wow.\n");
            Console.WriteLine("Press any key to exit. (The Power Button does not count, I tried)\n");
            Console.ReadKey();
        }
    }
}
