using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//source:  https://github.com/Optima-Energy-Systems/coding-challenges

namespace OES.RobotWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = new string[5];

            Console.WriteLine("Input Arena Size, ship location and instruction");
            userInput[0] = Console.ReadLine();
            userInput[1] = Console.ReadLine();
            userInput[2] = Console.ReadLine();
            userInput[3] = Console.ReadLine();
            userInput[4] = Console.ReadLine();

            LetsPlay letsPlay = new LetsPlay(userInput);
            letsPlay.CommandAndConquer();                                  

            Console.ReadLine();
        }


    }
}
