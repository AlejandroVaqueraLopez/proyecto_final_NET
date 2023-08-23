using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto_final_rpg
{
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
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                      \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
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
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("                   \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
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
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                               YOU ESCAPED FROM THE MAZE!!!! (Press ENTER to exit):                \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + 14);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  =>  ");
            Console.ReadLine();

            return true;
        }

        public void Warning(string warningMsg)
        {

            //second name
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (1));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (2));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (3));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (4));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (5));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (3));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("          " + warningMsg + "             ");
            Console.ReadLine();
        }

        public string[] PlayerName()
        {
            string[] completeName = new string[2];
            //name
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (1));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (2));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (3));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (4));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (5));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (3));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                           Set a name for your hero => "); completeName[0] = Console.ReadLine(); Console.Write("                             \x2590");

            //second name
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (1));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (2));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (3));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (4));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                                                                                   \x2590");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (5));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC\x25AC");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 50, (Console.WindowHeight / 2 - 3) + (3));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                           Set a second name for your hero => "); completeName[1] = Console.ReadLine(); Console.Write("                             \x2590");

            return completeName;
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

        public int MenuScene()
        {
            int opcSelected = 0;
            bool enter = false;

            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = "Flames-8-bit.wav";
            musicPlayer.Play();

            //selectable menu
            do
            {
                Console.Clear();
                Console.OutputEncoding = System.Text.Encoding.Unicode;

                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (1));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (2));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (3));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (4));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (5));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (6));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (7));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (8));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (9));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (10));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (11));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (12));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (13));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (14));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (15));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (16));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (17));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (18));
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (19));
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (20));
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (21));
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (22));
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, (Console.WindowHeight / 2 - 16) + (23));
                Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588");

                switch (opcSelected)
                {
                    case 0:
                        //question spot
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 23, (Console.WindowHeight / 2 - 3) + 12);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                 \x2588\x2588\x2588\x2588Play\x2588\x2588\x2588\x2588                \x2590");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 23, (Console.WindowHeight / 2 - 3) + 13);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                             \x2590");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 23, (Console.WindowHeight / 2 - 3) + 14);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                    Credits                  \x2590");
                        Console.WriteLine();
                        break;
                    case 1:
                        //question spot
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 23, (Console.WindowHeight / 2 - 3) + 12);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                     Play                    \x2590");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 23, (Console.WindowHeight / 2 - 3) + 13);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                                             \x2590");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 23, (Console.WindowHeight / 2 - 3) + 14);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x258C                \x2588\x2588\x2588\x2588Credits\x2588\x2588\x2588\x2588              \x2590");
                        Console.WriteLine();
                        break;
                }

                ConsoleKeyInfo key = new ConsoleKeyInfo();
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        opcSelected = 0;
                        break;
                    case ConsoleKey.DownArrow:
                        opcSelected = 1;
                        break;
                    case ConsoleKey.Enter:
                        enter = true;
                        break;
                }
            } while (!enter);

            return opcSelected;
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
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                       \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
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

        //This scene shows the characters ready to fight!
        public void skullFightSecondScene(string target, string color)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //line 1
            if (target == "hero" && color == "red")
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
            else if (target == "hero" && color == "green")
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

}
