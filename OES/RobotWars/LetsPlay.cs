using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OES.RobotWars
{
    public class LetsPlay
    {
        string[] gameParam = new string[5];
        Coordinates ArenaSize;

        public LetsPlay(string[] input)
        {
            gameParam = input;
        }

        public bool CommandAndConquer()
        {
            ArenaSize = GetArena(gameParam[0]);
            if (ArenaSize == null)
                return false;
           Ships shipOne = CheckShipInfo("One", gameParam[1]);
            if (shipOne == null)
                return false;
           Ships shipTwo = CheckShipInfo("Two", gameParam[3]);
            if (shipTwo == null)
                return false;

            Console.WriteLine("Output Position and Direction");
            MoveShip(shipOne, ArenaSize, gameParam[2]);
            MoveShip(shipTwo, ArenaSize, gameParam[4]);
            return true;
        }

        public Coordinates GetArena(string area)
        {
            string[] areaCoordinates = area.Split(' ');
            if (areaCoordinates.Length != 2)
            {
                Console.WriteLine("Invalid Arena Size!");
                return null;
            }
            int myVal = 0;
            if (!int.TryParse(areaCoordinates[0], out myVal))
            {
                Console.WriteLine("Invalid Arena Size!");
                return null;
            }
            int x = myVal;
            if (!int.TryParse(areaCoordinates[1], out myVal))
            {
                Console.WriteLine("Invalid Arena Size!");
                return null;
            }
            int y = myVal;
            return new Coordinates(x, y);
        }

        public Ships CheckShipInfo(string shipno, string input)
        {
            string[] cardinalLoc = { "N", "S", "E", "W" };
            string[] shipRaw = input.Split(' ');

            if (shipRaw.Length != 3)
            {
                Console.WriteLine("Invalid Ship " + shipno + " Information");
                return null;
            }
            int myVal = 0;
            if (!int.TryParse(shipRaw[0], out myVal))
            {
                Console.WriteLine("Invalid Ship " + shipno + " Information");
                return null;
            }
            int x = myVal;
            if (!int.TryParse(shipRaw[1], out myVal))
            {
                Console.WriteLine("Invalid Ship " + shipno + " Information");
                return null;
            }
            int y = myVal;
            var found = cardinalLoc.Where(j => j.Contains(shipRaw[2].ToUpper())).FirstOrDefault();
            if (found == null)
            {
                Console.WriteLine("Invalid Ship " + shipno + " Information");
                return null;
            }
            return new Ships(x, y, shipRaw[2].ToUpper());
        }

        public void MoveShip(Ships ships, Coordinates coordinates, string cmd)
        {
            if (cmd.Length > 0)            
                for (int i = 0; i < cmd.Length; i++)                
                    ships.Instruction(cmd.Substring(i, 1), coordinates);

            Console.WriteLine(ships.X.ToString() + " " + ships.Y.ToString() + " " + ships.Direction);
        }
    }
}
