using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_rpg
{

    public class Hero : Character
    {
        public int numPotion;
        public int numHelmet;
        public int numArmor;
        public int numGun;


        public void takePotion()
        {
            if (numPotion < 5)
            {
                numPotion++;

            }
        }
        public void takeHelmet()
        {
            if (numHelmet < 5)
            {
                numHelmet++;
                hp++;
            }
        }
        public void takeGun()
        {
            if (numGun < 5)
            {
                numGun++;
                ap++;
            }
        }
        public void takeArmor()
        {
            if (numArmor < 5)
            {
                numArmor++;
                hp++;
            }
        }

        public bool UsePotion() // Potion increments HP to the old register before fighting
        {
            int opc = 0;
            bool result = false;

            if (numPotion > 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("\nUse potion? (1. YES | 2. NO)  =>  ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        result = true;
                        break;
                    case 2:
                        result = false;
                        break;
                }

            }
            return result;

        }

        public void Move(string direction) //Move to any cardinal direction
        {
            switch (direction)
            {
                case "LEFT":
                    this.x--;
                    break;
                case "UP":
                    this.y--;
                    break;
                case "RIGHT":
                    this.x++;
                    break;
                case "DOWN":
                    this.y++;
                    break;
            }
        }
    }
}
