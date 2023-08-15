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

namespace Proyecto_final_rpg
{
    public class Character
    {
        //Properties
        public string name;
        public string secondName;
        public int hp;
        public int ap;

        //method
        public void attack()
        {
            //Console.WriteLine("attack: " + ap);
            hp--;
        }

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
            }
            else
            {
                Console.WriteLine("No puedes tomar mas armas!");
            }
        }
        public void takeArmour()
        {
            if (numArmor < 5)
            {
                numArmor++;
            }
            else
            {
                Console.WriteLine("No puedes tomar otra armadura!");
            }
        }

        public void usePotion()
        {
            numPotion--;
            Console.WriteLine(numPotion);
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

        public void gameOver()
        {
            Console.Clear();
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

            //Console.SetWindowSize(200, 50);
            //Console.SetBufferSize(200, 50);
            //Console.Clear();
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

            //Console.SetWindowSize(200, 50);
            //Console.SetBufferSize(200, 50);
            //Console.Clear();

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

        public void Ready()
        {
            counter++;
            System.Threading.Thread.Sleep(150);
        }

        public void ExecLoadingBar()
        {
            string loadingText = "Cargando....";
            Console.CursorVisible = false;

            for (int cont = 0; cont < 19; cont++)
            {
                LoadingBar(loadingText, Console.WindowHeight / 2, (Console.WindowWidth / 2 - loadingText.Length));
                Ready();
            }
        }
    }

    public class Map
    {


        //properties
        public const int N = 7;
        public const int M = 7;
        public int printingAcum = 0;
        public string[,] originalMap = new string[N, M]
        {
                { "L", " ", "L", "L", "L", " ", "L" },
                { "L", "S", "L", "W", "L", "F", "L" },
                { "L", "O", "L", "E", "L", "O", "L" },
                { "L", "A", "O", "O", "E", "O", "L" },
                { "L", "E", "L", "L", "O", "E", "L" },
                { "L", "H", "W", "L", "L", "A", "L" },
                { "L", "L", "L", "L", "L", "L", "L" }
        };

        public string[,] discoveredMap = new string[N, M]
        {
                { "L", " ", "L", "L", "L", " ", "L" },
                { "L", "S", "L", "X", "X", "X", "L" },
                { "L", "O", "L", "X", "X", "X", "L" },
                { "L", "X", "X", "X", "X", "X", "L" },
                { "L", "X", "X", "X", "X", "X", "L" },
                { "L", "X", "X", "X", "X", "X", "L" },
                { "L", "L", "L", "L", "L", "L", "L" }
        };

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
                        case "F": //Exit
                            Console.Write("F");
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


        public static void KeyPressEvent()
        {
            Console.WriteLine("Move");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                  Console.WriteLine("LEFT");
                    break;
                case ConsoleKey.UpArrow:
                    Console.WriteLine("UP");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("RIGHT");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("DOWN");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        static void Main(string[] args)
        {

            //initial values
            Hero hero = new Hero();
            hero.name = "Alexis";
            hero.secondName = "Sanchez";
            hero.hp = 3;
            hero.ap = 5;
            hero.numGun = 1;
            hero.numHelmet = 0;
            hero.numArmor = 0;
            hero.numPotion = 0;

            Character enemy = new Character();
            enemy.name = "Cucui";
            enemy.secondName = "Sanchez";
            enemy.hp = 4;
            enemy.ap = 5;

            Animations showTime = new Animations(hero.name, hero.secondName, enemy.name, enemy.secondName, hero.hp, enemy.hp, hero.ap, enemy.ap);



            do
            {
                showTime.ExecLoadingBar();

                Map firstLevel = new Map();
                firstLevel.PrintMap(hero.name, hero.secondName, hero.hp, hero.ap, hero.numGun, hero.numHelmet, hero.numArmor, hero.numPotion);

                KeyPressEvent();
                /* THIS WILL BE USED!!
                
                
                //atack process & animations
                showTime.preSkullFight();
                hero.attack();
                showTime.heroHp = hero.hp;
                showTime.heroAp = hero.ap;
                showTime.enemyHp = enemy.hp;
                showTime.enemyAp = enemy.ap;
                showTime.postSkullFight("enemy", "red");//who? and color
                */


                /*
                 effects code =>
                    hero,green
                    hero, red
                    enemy,red
                 */


            } while (hero.hp > 0);

            showTime.gameOver();
                        
            


            //Console.SetCursorPosition(0, 28);
            Console.ReadLine();
        }
    }
}
