using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OES.RobotWars
{
    public class Navigate
    {
        public void MoveShip(Ships ships, Coordinates coordinates, string cmd)
        {
            if (cmd.Length > 0)
            {
                for (int i = 0; i < cmd.Length; i++)
                {
                    ships.Instruction(cmd.Substring(i, 1), coordinates);
                }
            }
        }

    }
}
