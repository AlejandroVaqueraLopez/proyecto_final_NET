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


namespace Proyecto_final_rpg
{
    public class Map
    {
       // public 
    }

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
        public int numArmour;

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
            if (numPotion < 5)
            {
                numPotion++;
            }
            else
            {
                Console.WriteLine("No puedes tomar otro casco!");
            }
        }
        public void takeArmour()
        {
            if (numArmour < 5)
            {
                numPotion++;
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



        internal class Program
        {
        const int N = 5;
        const int M = 5;

        public static void KeyPressEvent()
        {
            Console.WriteLine("Press a key");
            //
            //Console.WriteLine(Console.ReadKey().Key);
            /*string myKey = Console.ReadKey().Key;
            switch (myKey)
            {
                case "DownArrow":
                    Console.WriteLine("LEFT");
                    break;
            }*/
        }



        static void Main(string[] args)
        {

            //initial values
            Hero hero = new Hero();
            hero.name = "Alexis";
            hero.secondName = "Sanchez";
            hero.hp = 3;
            hero.ap = 5;

            Character enemy = new Character();
            enemy.name = "Cucui";
            enemy.secondName = "Sanchez";
            enemy.hp = 4;
            enemy.ap = 5;

            Animations showTime = new Animations(hero.name, hero.secondName, enemy.name, enemy.secondName,  hero.hp, enemy.hp, hero.ap, enemy.ap);

            string [,] map = new string[N, M]
            {
                { "S", "L", "W", "L", "F"},
                { "O", "L", "E", "L", "O"},
                { "A", "O", "O", "E", "O"},
                { "E", "L", "L", "O", "E"},
                { "H", "W", "L", "L", "A"}
            };

            do
            {
                KeyPressEvent();
                /* THIS WILL BE USED!!
                showTime.ExecLoadingBar();
                
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
