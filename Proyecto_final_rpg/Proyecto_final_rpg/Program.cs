using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Web;
using System.Data;
using System.Media;

namespace Proyecto_final_rpg
{
    public class Character
    {
        //Properties
        public string name;
        public string secondName;
        public int hp;
        public int ap;
        public int x;
        public int y;
        public void printPersonalInfo()
        {
            Console.WriteLine(name + secondName);
        }

    }

    public class Hero: Character
    {
        public int numPotion;
        public int numHelmet;
        public int numArmor;
        public int numGun;


        public void takePotion()
        {
            if(numPotion < 5)
            {
                numPotion++;

            }
            else
            {
                Console.WriteLine("No puedes tomar otra pocion!");
            }
        }
        public void takeHelmet()
        {
            if (numHelmet < 5)
            {
                numHelmet++;
                hp++;
            }
            else
            {
                Console.WriteLine("No puedes tomar mas cascos");
            }
        }
        public void takeGun()
        {
            if (numGun < 5)
            {
                numGun++;
                ap++;
            }
            else
            {
                Console.WriteLine("No puedes tomar mas armas!");
            }
        }
        public void takeArmor()
        {
            if (numArmor < 5)
            {
                numArmor++;
                hp++;
            }
            else
            {
                Console.WriteLine("No puedes tomar otra armadura!");
            }
        }

        public bool UsePotion() // Potion increments HP to the old register before fighting
        {
            int opc = 0;
            bool result = false;

            if(numPotion > 0)
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


  /// ////////////////////////////
       

    public class Animations
    {
        public string heroName;
        public string heroSecondName;
        public string enemyName;
        public string enemySecondName;
        public int heroHp;
        public int heroAp;
        public int enemyHp;
        public int enemyAp;
        public int counter;

        public Animations(string heroName, string heroSecondName, string enemyName, string enemySecondName, int heroHp, int enemyHp, int heroAp, int enemyAp)
        {
            this.heroName = heroName;
            this.heroSecondName = heroSecondName;
            this.enemyName = enemyName;
            this.enemySecondName = enemySecondName;
            this.heroHp = heroHp;
            this.heroAp = heroAp;
            this.enemyHp = enemyHp;
            this.enemyAp = enemyAp;
        }

        public bool TakePotion()
        {
            int opc = 0;
            bool taken = false;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //potion drawing
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 1);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                       \x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 2);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                      \x2588\x2588");  Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 3);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                       \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 4);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 5);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                  \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 6);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 7);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("              \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 8);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("              \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 9);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 10);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 11);

            //question spot
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (7));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (8));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (9));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                  Save the potion? (1. YES | 2.NO):                                \x2590"); 
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (10));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (11));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");  
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    taken = true;
                    break;
                case 2:
                    taken = false;
                    break;
            }
            return taken;

        }

        public bool TakeArmor()
        {
            int opc = 0;
            bool taken = false;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //potion drawing
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 1);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                  \x2588\x2588\x2588\x2588        \x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 2);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("              \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("    \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 3);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("    \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 4);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 5);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 6);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 7);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 8);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 9);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 10);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                  \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 11);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                    \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");



            //question spot
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (7));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (8));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (9));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                  Take the Armor? (1. YES | 2.NO):                                 \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (10));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (11));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    taken = true;
                    break;
                case 2:
                    taken = false;
                    break;
            }
            return taken;

        }

        public bool TakeGun()
        {
            int opc = 0;
            bool taken = false;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //potion drawing
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 1);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                                        \x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 2);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                                      \x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 3);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                                    \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 4);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                                  \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 5);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                                \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 6);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 7);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 8);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                          \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 9);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                        \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 10);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("                  \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("  \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 11);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("                \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 12);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 13);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("               \x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 14);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("             \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 15);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 16);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("             \x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 17);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("               \x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 15) + 17);


            //question spot
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (7));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (8));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (9));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                  Take the blade? (1. YES | 2.NO):                                 \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (10));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (11));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    taken = true;
                    break;
                case 2:
                    taken = false;
                    break;
            }
            return taken;

        }

        public bool TakeHelmet()
        {
            int opc = 0;
            bool taken = false;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //potion drawing
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 1);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                       \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 2);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                     \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 3);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                   \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 4);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                   \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 5);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                   \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");  Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 6);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                   \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 7);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                   \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 8);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                   \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 9);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); 
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, (Console.WindowHeight / 2 - 10) + 10);

            //question spot
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (7));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (8));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (9));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                  Save the Helmet? (1. YES | 2.NO):                                \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (10));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (11));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    taken = true;
                    break;
                case 2:
                    taken = false;
                    break;
            }
            return taken;

        }

        public bool VictoryScene()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (1));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (2));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (3));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (4));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (5));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (6));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (7));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (8));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (9));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (10));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (11));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (12));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (13));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (14));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (15));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (16));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (17));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (18));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (19));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (20));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (21));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (22));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (23));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");

            //question spot
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 12);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 13);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                               YOU ESCAPED FROM THE MAZE!!!! (Press ENTER to exit):                          \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 14);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");
            Console.ReadLine();

            return true;
        }


        public bool EnemyChoose()
        {
            int opc = 0;
            bool taken = false;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (1));
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write(""); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (2));
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write(""); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("      \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (3));
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (4));
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("   "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (5));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("   "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (6));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("   "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (7));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("   "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (8));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("   "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (9));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("  "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (10));
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("   "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, (Console.WindowHeight / 2 - 13) + (11));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("   "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588");


            //question spot
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (7));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (8));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (9));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                           Skull enemy found!! (1. FIGHT | 2. ESCAPE):                             \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (10));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (11));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    taken = true;
                    break;
                case 2:
                    taken = false;
                    break;
            }
            return taken;

        }

        public bool MenuScene()
        {
            int opcSelected = 0;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (1));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (2));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (3));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (4));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (5));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (6));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (7));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (8));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (9));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (10));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (11));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (12));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (13));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (14));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (15));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (16));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (17));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (18));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (19));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (20));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (21));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (22));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (23));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");

            do
            {
                switch(opcSelected)
                {
                    case 0:
                        //question spot
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 12);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 13);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                               YOU ESCAPED FROM THE MAZE!!!! (Press ENTER to exit):                          \x2590");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 14);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");
                        Console.ReadLine();
                        break;
                }

                ConsoleKeyInfo key = new ConsoleKeyInfo();
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        //Console.WriteLine("LEFT");
                        if ((hero.x - 1) > 0 && firstLevel.originalMap[hero.y, (hero.x - 1)] != "L") //&& firstLevel.originalMap[hero.y, (hero.x - 1)] != "L"
                        {
                            hero.Move("LEFT");
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        //Console.WriteLine("UP");
                        if ((hero.y - 1) > 0 && firstLevel.originalMap[hero.y - 1, hero.x] != "L")
                        {
                            hero.Move("UP");
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        //Console.WriteLine("RIGHT");
                        if ((hero.x + 1) < 7 - 1 && firstLevel.originalMap[hero.y, (hero.x + 1)] != "L")
                        {
                            hero.Move("RIGHT");
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        //Console.WriteLine("DOWN");
                        if ((hero.y + 1) < 7 - 1 && firstLevel.originalMap[(hero.y + 1), hero.x] != "L")
                        {
                            hero.Move("DOWN");
                        }
                        break;
                }
            } while (true);
            

            return true;
        }


        public void GameOver()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //line 1
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (1));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (2));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (3));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (4));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (5));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (6));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (7));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (8));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (9));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (10));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (11));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (12));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (13));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (14));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (15));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (16));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (17));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (18));
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (19));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (20));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (21));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (22));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 22, (Console.WindowHeight / 2 - 16) + (23));
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            //question spot
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 12);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 13);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                  GAME OVER!!!! (Press ENTER to exit):                             \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 14);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");

            Console.ReadLine();
        }


        //This scene shows the characters ready to fight!
        public void skullFightFirstScene()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //line 1
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("      \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                        "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588");

            string heroHpBlocks = "";
            string enemyHpBlocks = "";
            string heroApBlocks = "";
            string enemyApBlocks = "";

            string blankSpaces = "";
            string spaceUsed = "";

            int spacesNeeded = 100;


            spaceUsed = heroName + " " + heroSecondName;

            Console.WriteLine();
            Console.WriteLine();
            //Indicators
            for (int cont = 0; cont < (100 - spaceUsed.Length); cont++)
            {
                blankSpaces = blankSpaces + "\x00A0";
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("         " + heroName + " " + heroSecondName); Console.Write(blankSpaces); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(enemyName + " " + enemySecondName);

            //Indicators
            for (int cont = 0; cont < heroHp * 4; cont++)
            {
                heroHpBlocks = heroHpBlocks + "\x2588";
            }
            for (int cont = 0; cont < enemyHp * 4; cont++)
            {
                enemyHpBlocks = enemyHpBlocks + "\x2588";
            }

            Console.WriteLine();
            Console.WriteLine();
            blankSpaces = "";
            //Indicators
            for (int cont = 0; cont < (100 - (heroHpBlocks.Length + 5)) ; cont++)
            {
                blankSpaces = blankSpaces + "\x00A0";
            }
            Console.ForegroundColor = ConsoleColor.White; Console.Write("         HP "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(heroHp + " " + heroHpBlocks); Console.Write(blankSpaces); Console.ForegroundColor = ConsoleColor.White; Console.Write("HP "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(enemyHp + " " + enemyHpBlocks);

            //Indicators
            for (int cont = 0; cont < heroAp * 4; cont++)
            {
                heroApBlocks = heroApBlocks + "\x2588";
            }
            for (int cont = 0; cont < enemyAp * 4; cont++)
            {
                enemyApBlocks = enemyApBlocks + "\x2588";
            }

            Console.WriteLine();
            Console.WriteLine();
            blankSpaces = "";
            //Indicators
            for (int cont = 0; cont < (100 - (heroApBlocks.Length + 5)); cont++)
            {
                blankSpaces = blankSpaces + "\x00A0";
            }
            Console.ForegroundColor = ConsoleColor.White; Console.Write("         AP "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(heroAp + " " + heroApBlocks); Console.Write(blankSpaces); Console.ForegroundColor = ConsoleColor.White; Console.Write("AP "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(enemyAp + " " + enemyApBlocks);

        }

        //This scene shows the characters ready to fight!
        public void skullFightSecondScene(string target, string color)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //line 1
            if(target == "hero" && color == "red")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("      \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.Write("                                                                        "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588");

            }
            else if(target == "hero" && color == "green")
            
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("      \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                        "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588");

            }
            else if (target == "enemy" && color == "red")

            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("      \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                        "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588");

            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("      \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                        "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588");

            }


            string heroHpBlocks = "";
            string enemyHpBlocks = "";
            string heroApBlocks = "";
            string enemyApBlocks = "";

            string blankSpaces = "";
            string spaceUsed = "";

            int spacesNeeded = 100;


            spaceUsed = heroName + " " + heroSecondName;

            Console.WriteLine();
            Console.WriteLine();
            //Indicators
            for (int cont = 0; cont < (100 - spaceUsed.Length); cont++)
            {
                blankSpaces = blankSpaces + "\x00A0";
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("         " + heroName + " " + heroSecondName); Console.Write(blankSpaces); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(enemyName + " " + enemySecondName);

            //Indicators
            for (int cont = 0; cont < heroHp * 4; cont++)
            {
                heroHpBlocks = heroHpBlocks + "\x2588";
            }
            for (int cont = 0; cont < enemyHp * 4; cont++)
            {
                enemyHpBlocks = enemyHpBlocks + "\x2588";
            }

            Console.WriteLine();
            Console.WriteLine();
            blankSpaces = "";
            //Indicators
            for (int cont = 0; cont < (100 - (heroHpBlocks.Length + 5)); cont++)
            {
                blankSpaces = blankSpaces + "\x00A0";
            }
            Console.ForegroundColor = ConsoleColor.White; Console.Write("         HP "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(heroHp + " " + heroHpBlocks); Console.Write(blankSpaces); Console.ForegroundColor = ConsoleColor.White; Console.Write("HP "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(enemyHp + " " + enemyHpBlocks);

            //Indicators
            for (int cont = 0; cont < heroAp * 4; cont++)
            {
                heroApBlocks = heroApBlocks + "\x2588";
            }
            for (int cont = 0; cont < enemyAp * 4; cont++)
            {
                enemyApBlocks = enemyApBlocks + "\x2588";
            }

            Console.WriteLine();
            Console.WriteLine();
            blankSpaces = "";
            //Indicators
            for (int cont = 0; cont < (100 - (heroApBlocks.Length + 5)); cont++)
            {
                blankSpaces = blankSpaces + "\x00A0";
            }
            Console.ForegroundColor = ConsoleColor.White; Console.Write("         AP "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(heroAp + " " + heroApBlocks); Console.Write(blankSpaces); Console.ForegroundColor = ConsoleColor.White; Console.Write("AP "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(enemyAp + " " + enemyApBlocks);

        }

        public void ClearSpaces()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public void RefreshCharacters()
        {
            for (int cont = 0; cont < 23; cont++)
            {
                Console.SetCursorPosition(0, cont);
                ClearSpaces();
            }
        }


        //This scene shows the characters ready to fight!
        public void preSkullFight()
        {
                Console.Clear();
                skullFightFirstScene();
                Thread.Sleep(1000);

                Console.Clear();
                skullFightSecondScene(" ", " ");
                Thread.Sleep(250);

                Console.Clear();
                skullFightFirstScene();
                Thread.Sleep(1000);

                Console.Clear();
                skullFightSecondScene(" ", " ");
                Thread.Sleep(250);

        }

        //This scene shows the characters ready to fight!
        public void postSkullFight(string target, string color)
        {
                Console.Clear();
                skullFightFirstScene();
                Thread.Sleep(1000);

                Console.Clear();
                skullFightSecondScene(target, color);
                Thread.Sleep(250);

                Console.Clear();
                skullFightFirstScene();
                Thread.Sleep(1000);

                Console.Clear();
                skullFightSecondScene(target, color);
                Thread.Sleep(250);

                Console.Clear();
                skullFightFirstScene();
                Thread.Sleep(1000);

                Console.Clear();
                skullFightSecondScene(target, color);
                Thread.Sleep(250);

                Console.Clear();
                skullFightFirstScene();
                Thread.Sleep(1000);

                Console.Clear();
                skullFightSecondScene(target, color);
                Thread.Sleep(250);
        }


        public void LoadingBar(string loadingTest, int row, int column)
        {
            Console.Clear();
            Console.SetCursorPosition(column, row);
            string loadingText = loadingTest + " [";
            string loadingTextTerminator = "                   ]";
            Console.Write(loadingText + loadingTextTerminator);

            for (int i = 0; i < counter % 20; i++)
            {
                if (counter == 0)
                {
                    Console.SetCursorPosition(column, row);
                    Console.Write(loadingText + loadingTextTerminator);
                }

                Console.SetCursorPosition(column + loadingText.Length + i, row);
                Console.Write("\x2588\x2588");
            }
        }

        public void Ready(int duration)
        {
            counter++;
            System.Threading.Thread.Sleep(duration);
        }

        public void ExecLoadingBar(string loadingText, int duration)
        {
            
            Console.CursorVisible = false;

            for (int cont = 0; cont < 19; cont++)
            {
                LoadingBar(loadingText, Console.WindowHeight / 2, (Console.WindowWidth / 2 - loadingText.Length));
                Ready(duration);
            }
        }
    }

    public class Map
    {
        //properties
        public const int N = 7;
        public const int M = 7;
        public int printingAcum = 0;
        public int[] ItemsAround = new int[8];

        public string[,] originalMap = new string[N, M]
        {
                { "L", " ", "L", "L", "L", " ", "L" },
                { "L", "S", "L", "W", "L", "F", "L" },
                { "L", "O", "L", "E", "L", "O", "L" },
                { "L", "A", "O", "O", "E", "O", "L" },
                { "L", "E", "L", "L", "O", "P", "L" },
                { "L", "P", "W", "L", "L", "A", "L" },
                { "L", "L", "L", "L", "L", "L", "L" }
        };

        public string[,] discoveredMap = new string[N, M]
        {
                { "L", " ", "L", "L", "L", " ", "L" },
                { "L", "■", "L", "X", "X", "X", "L" },
                { "L", "O", "L", "X", "X", "X", "L" },
                { "L", "X", "X", "X", "X", "X", "L" },
                { "L", "X", "X", "X", "X", "X", "L" },
                { "L", "X", "X", "X", "X", "X", "L" },
                { "L", "L", "L", "L", "L", "L", "L" }
        };

       
        //Methods
        public bool DetectItem(string item)
        {
            switch (item)
            {
                case "E":
                    return true; //enemy
                    break;
                default:
                    return false; //Nothing
                    break;
            }
        }

        //Searches enemies around the position of the hero
        public int[] FindEnemies(int row, int col)
        {
            
            int count = -1;
            int enemiesFound = 0;
            int[] enemiesPositions = new int[8];

            //(row,-) LEFT
            if ((col - 1) > 0) 
            {
               if(DetectItem(this.discoveredMap[row, (col - 1)]))
                {
                    enemiesFound++;
                    enemiesPositions[++count] = row;
                    enemiesPositions[++count] = (col - 1);

                }
                //ItemsAround[count] = DetectItem(this.discoveredMap[row, (col - 1)]);
            }
            /*//(-,-) LEFT UP
            if ((col - 1) > 0 && (row - 1) > 0) 
            {
                if (DetectItem(this.discoveredMap[(row - 1), (col - 1)]))
                {
                    enemiesFound++;
                }
                //ItemsAround[++count] = DetectItem(this.discoveredMap[(row - 1), (col - 1)]);
            }*/
            //(-,col) UP
            if ((row - 1) > 0)
            {
                if (DetectItem(this.discoveredMap[(row - 1), col]))
                {
                    enemiesFound++;
                    enemiesPositions[++count] = row - 1;
                    enemiesPositions[++count] = col;
                }
                //ItemsAround[++count] = DetectItem(this.discoveredMap[(row - 1), col]);
            }
            /*//(-,+) RIGHT UP
            if ((col + 1) < M && (row - 1) > 0)
            {
                if (DetectItem(this.discoveredMap[(row - 1), col + 1]))
                {
                    enemiesFound++;
                }
                //ItemsAround[++count] = DetectItem(this.discoveredMap[(row - 1), (col + 1)]);
            }*/
            //(row,+) RIGHT
            if ((col + 1) < M)
            {
                if (DetectItem(this.discoveredMap[row, col + 1]))
                {
                    enemiesFound++;
                    enemiesPositions[++count] = row;
                    enemiesPositions[++count] = col + 1;
                }
                ///ItemsAround[++count] = DetectItem(this.discoveredMap[row, (col + 1)]);
            }

            /*//(+,+) RIGHT DOWN
            if ((col + 1) < M && (row + 1) < N)
            {
                if (DetectItem(this.discoveredMap[(row + 1), col + 1]))
                {
                    enemiesFound++;
                }
                //ItemsAround[++count] = DetectItem(this.discoveredMap[(row + 1), (col + 1)]);
            }*/

            //(+,col) DOWN
            if ((row + 1) < N)
            {
                if (DetectItem(this.discoveredMap[(row + 1), col]))
                {
                    enemiesFound++;
                    enemiesPositions[++count] = row + 1;
                    enemiesPositions[++count] = col;

                }
                //ItemsAround[++count] = DetectItem(this.discoveredMap[(row + 1), col]);
            }

            /*//(+,-) DOWN LEFT
            if ((row + 1) < N && (col - 1) > 0)
            {
                if (DetectItem(this.discoveredMap[(row + 1), col - 1]))
                {
                    enemiesFound++;
                }
                //ItemsAround[++count] = DetectItem(this.discoveredMap[(row + 1), (col - 1)]);
            }*/
            
            return enemiesPositions;

        }

        //KILLS A POSITION
        public void KillPosition(int row, int col)
        {
            originalMap[row, col] = "O";
        }

        public void UpdateDiscoveredMap(int row, int col, bool destroyOldPosition)
        {
            int counter = 0;
            int cpRow = 0;
            int cpCol = 0;

            int oldRow = 0;
            int oldcol = 0;

            //Hero myHero = new Hero();

            for (int rowCont = 0; rowCont < N; rowCont++)
            {
                for (int colCont = 0; colCont < M; colCont++)
                {
                    if (discoveredMap[rowCont, colCont] == "\x25A0")
                    {
                        oldRow = rowCont;
                        oldcol = colCont;
                    }
                }
            }


            //Discovering areas
            this.discoveredMap[row, col] = "\x25A0"; //move the hero value to the new spot
            if (destroyOldPosition)
            {
                this.originalMap[oldRow, oldcol] = "O"; //we destroy old position in original map
                this.discoveredMap[oldRow, oldcol] = this.originalMap[oldRow, oldcol]; //replace the blank space with the original element
            }
            else
            { 
                this.discoveredMap[oldRow, oldcol] = this.originalMap[oldRow, oldcol]; //replace the blank space with the original element
            }
            

            //(row,col)
            //DISCOVER ALL AROUND AREA FROM NEW POSITION
            //(row,-) LEFT
            if((col - 1) > 0) { this.discoveredMap[row, (col - 1)] = this.originalMap[row, (col - 1)]; }
            
            //(-,-) LEFT UP
            if ((col - 1) > 0 && (row - 1) > 0) { this.discoveredMap[(row - 1), (col - 1)] = this.originalMap[(row - 1), (col - 1)]; }
            
            //(-,col) UP
            if ((row - 1) > 0) { this.discoveredMap[(row - 1), col] = this.originalMap[(row - 1), col]; }
            
            //(-,+) RIGHT UP
            if ((col + 1) < M && (row - 1) > 0) { this.discoveredMap[(row - 1), (col + 1)] = this.originalMap[(row - 1), (col + 1)]; }
            
            //(row,+) RIGHT
            if ((col + 1) < M) { this.discoveredMap[row, (col + 1)] = this.originalMap[row, (col + 1)]; }
            
            //(+,+) RIGHT DOWN
            if ((col + 1) < M && (row + 1) < N) { this.discoveredMap[(row + 1), (col + 1)] = this.originalMap[(row + 1), (col + 1)]; }
            
            //(+,col) DOWN
            if ((row + 1) < N) { this.discoveredMap[(row + 1), col] = this.originalMap[(row + 1), col]; }
            
            //(+,-) DOWN LEFT
            if ((row + 1) < N && (col - 1) > 0) { this.discoveredMap[(row + 1), (col - 1)] = this.originalMap[(row + 1), (col - 1)]; }
            
        }

        public void PrintMap(string name, string secondName, int hp, int ap, int gun, int helmet, int armor, int potion)
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            for(int row = 0; row < N; row++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, (Console.WindowHeight / 2 - 3) + row);
                for (int col = 0; col < M; col++)
                {
                    switch (discoveredMap[row, col])
                    {
                        case "L": //wall
                            Console.Write("L");
                            break;
                        case "S": //Entrance
                            Console.Write("S");
                            break;
                        case "E": //Enemy
                            Console.Write("E");
                            break;
                        case "O": //Blank space
                            Console.Write("O");
                            break;
                        case "X": //Undiscovered area
                            Console.Write("X");
                            break;
                        case " ": //Blank space
                            Console.Write(" ");
                            break;
                        case "H": //Helmet
                            Console.Write("H");
                            break;
                        case "W": //Gun
                            Console.Write("W");
                            break;
                        case "A": //Armor
                            Console.Write("A");
                            break;
                        case "F": //Exit
                            Console.Write("F");
                            break;
                        case "P": //Potion
                            Console.Write("P");
                            break;
                        case "\x25A0": //Hero
                            Console.Write("\x25A0");
                            break;
                    };
                    Console.Write(" ");
                }
            }
                
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (N + 5));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (N + 6));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (N + 7));  
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C    " + name); Console.ForegroundColor = ConsoleColor.Green; Console.Write("    \x2588\x2588 HP: " + hp); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("  \x2588\x2588 AP: " + ap); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("   \x2588\x2588 Armas: " + gun); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("   \x2588\x2588 Armaduras: " + armor); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("   \x2588\x2588 Cascos: " + helmet); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("   \x2588\x2588 Pociones: " + potion); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (N + 8));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C    " + secondName + "                                                                                        \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (N + 9));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
        
        }
    }


        internal class Program
        {
        static void Main(string[] args)
        {
            //main variables
            bool potionTaken = false;
            bool helmetTaken = false;
            bool fightWithEnemy = false; //temp
            bool gunTaken = false;
            bool armorTaken = false;
            bool victory = false;
            bool heroIsDead = false;
            bool enemyIsDead = false;

            int[] enemyArray = new int[8];

            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = "Out-Of-Time-8-bit.wav";
            musicPlayer.Play();

            Random randomGenerator = new Random();

            //initial values
            Hero hero = new Hero();
            hero.name = "Alexis";
            hero.secondName = "Sanchez";
            hero.hp = randomGenerator.Next(1, 6);
            hero.ap = randomGenerator.Next(1, 3);
            hero.numGun = 0;
            hero.numHelmet = 0;
            hero.numArmor = 0;
            hero.numPotion = 0;
            hero.x = 1;
            hero.y = 1;

            Character enemy = new Character();
            enemy.name = "Cucui";
            enemy.secondName = "Sanchez";
            enemy.hp = 2;
            enemy.ap = 1;

            Animations showTime = new Animations(hero.name, hero.secondName, enemy.name, enemy.secondName, hero.hp, enemy.hp, hero.ap, enemy.ap);
            
            Map firstLevel = new Map();

            firstLevel.PrintMap(hero.name, hero.secondName, hero.hp, hero.ap, hero.numGun, hero.numHelmet, hero.numArmor, hero.numPotion);
            bool isOverSomething = false;
            bool musicFlag = false;

            do
            {
                if (musicFlag == false)
                {
                    musicPlayer.Stop();
                    musicPlayer.SoundLocation = "Out-Of-Time-8-bit.wav";
                    musicPlayer.Play();
                    musicFlag = true;
                }

                firstLevel.PrintMap(hero.name, hero.secondName, hero.hp, hero.ap, hero.numGun, hero.numHelmet, hero.numArmor, hero.numPotion);
                

                if (isOverSomething) //we need to kill an item
                {
                    //Movement functions///////////////////////////////////////////////
                    Console.WriteLine("Move");
                    ConsoleKeyInfo key = new ConsoleKeyInfo();
                    key = Console.ReadKey();

                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            //Console.WriteLine("LEFT");
                            if ((hero.x - 1) > 0 && firstLevel.originalMap[hero.y, (hero.x - 1)] != "L") //&& firstLevel.originalMap[hero.y, (hero.x - 1)] != "L"
                            {
                                hero.Move("LEFT");
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            //Console.WriteLine("UP");
                            if ((hero.y - 1) > 0 && firstLevel.originalMap[hero.y - 1, hero.x] != "L")
                            {
                                hero.Move("UP");
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            //Console.WriteLine("RIGHT");
                            if ((hero.x + 1) < 7 - 1 && firstLevel.originalMap[hero.y, (hero.x + 1)] != "L")
                            {
                                hero.Move("RIGHT");
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            //Console.WriteLine("DOWN");
                            if ((hero.y + 1) < 7 - 1 && firstLevel.originalMap[(hero.y + 1), hero.x] != "L")
                            {
                                hero.Move("DOWN");
                            }
                            break;
                    }

                    //update discovered areas in map
                    firstLevel.UpdateDiscoveredMap(hero.y, hero.x, true); //row, col, destroy old position?

                    //print discovered map
                    firstLevel.PrintMap(hero.name, hero.secondName, hero.hp, hero.ap, hero.numGun, hero.numHelmet, hero.numArmor, hero.numPotion);

                    isOverSomething = false;//flag down

                }
                else //just moving around map
                {
                    //Movement functions///////////////////////////////////////////////
                    Console.WriteLine("Move");
                    ConsoleKeyInfo key = new ConsoleKeyInfo();
                    key = Console.ReadKey();

                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            //Console.WriteLine("LEFT");
                            if ((hero.x - 1) > 0 && firstLevel.originalMap[hero.y, (hero.x - 1)] != "L") //&& firstLevel.originalMap[hero.y, (hero.x - 1)] != "L"
                            {
                                hero.Move("LEFT");
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            //Console.WriteLine("UP");
                            if ((hero.y - 1) > 0 && firstLevel.originalMap[hero.y - 1, hero.x] != "L")
                            {
                                hero.Move("UP");
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            //Console.WriteLine("RIGHT");
                            if ((hero.x + 1) < 7 - 1 && firstLevel.originalMap[hero.y, (hero.x + 1)] != "L")
                            {
                                hero.Move("RIGHT");
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            //Console.WriteLine("DOWN");
                            if ((hero.y + 1) < 7 - 1 && firstLevel.originalMap[(hero.y + 1), hero.x] != "L")
                            {
                                hero.Move("DOWN");
                            }
                            break;
                    }

                    //update discovered areas in map
                    firstLevel.UpdateDiscoveredMap(hero.y, hero.x, false);//row, col, destroy old position?

                    //print discovered map
                    firstLevel.PrintMap(hero.name, hero.secondName, hero.hp, hero.ap, hero.numGun, hero.numHelmet, hero.numArmor, hero.numPotion);

                    //If we are over an item, TAKE OR NOT ANIMATION (checks in original map if there is an item under hero position)
                    switch (firstLevel.originalMap[hero.y, hero.x])
                    {
                        
                        case "H":
                            showTime.ExecLoadingBar("OH what's this??", 50);
                            helmetTaken = showTime.TakeHelmet();//executes the potion animation and returns the response
                            if (helmetTaken)
                            {
                                hero.takeHelmet(); 
                                isOverSomething = true;
                            }
                            break;
                        case "W":
                            showTime.ExecLoadingBar("OH what's this??", 50);
                            gunTaken = showTime.TakeGun();//executes the potion animation and returns the response
                            if (gunTaken)
                            {
                                hero.takeGun(); 
                                isOverSomething = true;
                            }
                            break;
                        case "A":
                            showTime.ExecLoadingBar("OH what's this??", 50);
                            armorTaken = showTime.TakeArmor();//executes the potion animation and returns the response
                            if (armorTaken)
                            {
                                hero.takeArmor(); 
                                isOverSomething = true;
                            }
                            break;
                        case "F":
                            showTime.ExecLoadingBar("Is this the end??", 50);
                            victory = showTime.VictoryScene();
                            break;
                        case "P":
                            showTime.ExecLoadingBar("OH what's this??", 50);
                            potionTaken = showTime.TakePotion();//executes the potion animation and returns the response
                            if (potionTaken)
                            {
                                hero.takePotion(); 
                                isOverSomething = true;
                            }
                            break;
                    };
                    
                    //this counts the enemies around
                    enemyArray = firstLevel.FindEnemies(hero.y, hero.x); //returns how many enemies we have to fight couse of our location
                    
                    //this is to kill the positions of enemies
                    for(int cont = 0; cont < 8; cont+=2)
                    {
                        if (enemyArray[cont] != 0 || enemyArray[cont + 1] != 0)
                        {
                            fightWithEnemy = showTime.EnemyChoose();//executes the potion animation and returns the response
                            if (fightWithEnemy)
                            {
                                showTime.ExecLoadingBar("Get ready to fight!", 150);
                                //starting values
                                musicFlag = true;
                                int startingHp = hero.hp;
                                enemy.hp = randomGenerator.Next(1, 6);
                                enemy.ap = randomGenerator.Next(1, 3);
                                heroIsDead = false;
                                enemyIsDead = false;

                                if (musicFlag == true)
                                {
                                    musicPlayer.Stop();
                                    musicPlayer.SoundLocation = "Master-of-Puppets-8-bit.wav";
                                    musicPlayer.Play();
                                    musicFlag = false;
                                }
                                do
                                {

                                    ////////////////////////////////atack process & animations   
                                    ///HERO ATTACK
                                    //showTime.preSkullFight();

                                    showTime.heroHp = hero.hp;
                                    showTime.heroAp = hero.ap;
                                    showTime.enemyHp = enemy.hp;
                                    showTime.enemyAp = enemy.ap;
                                    showTime.postSkullFight("enemy", "red");//who? and color
                                    enemy.hp -= hero.ap;
                                    ///ENEMY ATTACK
                                    showTime.heroHp = hero.hp;
                                    showTime.heroAp = hero.ap;
                                    showTime.enemyHp = enemy.hp;
                                    showTime.enemyAp = enemy.ap;
                                    showTime.postSkullFight("hero", "red");//who? and color
                                    hero.hp -= enemy.ap;

                                    if (hero.UsePotion())
                                    {
                                        hero.numPotion--;
                                        hero.hp += (startingHp - hero.hp);
                                    }

                                    if (hero.hp <= 0)
                                    {
                                        heroIsDead = true;
                                    }
                                    else if(enemy.hp <= 0)
                                    {
                                        enemyIsDead = true;
                                        //kill the position of enemy
                                        firstLevel.KillPosition(enemyArray[cont], enemyArray[cont + 1]); //row col
                                        //update discovered areas in map
                                        firstLevel.UpdateDiscoveredMap(hero.y, hero.x, false);//row, col, destroy old position?
                                    }


                                    /*
                                     effects code =>
                                        hero,green
                                        hero, red
                                        enemy,red
                                     */

                                } while (!heroIsDead && !enemyIsDead);
                            }
                        }
                    }

                }


            } while (!heroIsDead && !victory);

            if (heroIsDead)
            {
                showTime.GameOver();
            }
            else if (victory)
            {
                showTime.VictoryScene();
            }

            Console.Clear();
            Console.WriteLine("Level 2 coming soon.....!");
            Console.ReadLine();
        }
    }
}
