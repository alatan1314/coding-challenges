using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OES.RobotWars
{
    public class Ships : Coordinates
    {
        public string Direction { get; set; }

        public Ships(int xloc, int yloc, string facing): base(xloc, yloc)
        {           
            Direction = facing;
        }
        public bool Instruction(string instruction, Coordinates arena)
        {
            bool result = true;

            if (instruction.CompareTo("L") == 0)
            {
                switch (Direction)
                {
                    case "N":
                        Direction = "W";
                        break;
                    case "W":
                        Direction = "S";
                        break;
                    case "S":
                        Direction = "E";
                        break;
                    default:
                        Direction = "N";
                        break;
                }
            }
            else if (instruction.CompareTo("R") == 0)
            {
                switch (Direction)
                {
                    case "N":
                        Direction = "E";
                        break;
                    case "W":
                        Direction = "N";
                        break;
                    case "S":
                        Direction = "W";
                        break;
                    default:
                        Direction = "S";
                        break;
                }
            }
            else if (instruction.CompareTo("M") == 0)
            {
                if (!MoveShip(arena))
                {
                    result = false;
                    Console.WriteLine("Invalid new position!");
                }
            }
            else
            {
                result = false;
                Console.WriteLine("Invalid Instruction!: " + instruction);
            }
            return result;
        }
        private bool MoveShip(Coordinates arena)
        {
            bool result = true;
            switch (Direction)
            {
                case "N":
                    Y++;
                    break;
                case "W":
                    X--;
                    break;
                case "S":
                    Y--;
                    break;
                default:
                    X++;
                    break;
            }
            if ((Y < 0) || (Y > arena.Y))  // Check if outside Areana
                result = false;
            if ((X < 0) || (X > arena.X)) // Check if outside Areana
                result = false;
            return result;
        }
    }
}
