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
            Console.WriteLine("attack: " + ap);
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


    public class Spinner : IDisposable
    {
        private const string Sequence = @"/-\|";
        private int counter = 0;
        private readonly int left;
        private readonly int top;
        private readonly int delay;
        private bool active;
        private readonly Thread thread;

        public Spinner(int left, int top, int delay = 100)
        {
            this.left = left;
            this.top = top;
            this.delay = delay;
            thread = new Thread(Spin);
        }

        public void Start()
        {
            active = true;
            if (!thread.IsAlive)
                thread.Start();
        }

        public void Stop()
        {
            active = false;
            Draw(' ');
        }

        private void Spin()
        {
            while (active)
            {
                Turn();
                Thread.Sleep(delay);
            }
        }

        private void Draw(char c)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(c);
        }

        private void Turn()
        {
            Draw(Sequence[++counter % Sequence.Length]);
        }

        public void Dispose()
        {
            Stop();
        }
    }


  /// <summary>
  /// ////////////////////////////
  /// </summary>
       
 

    public class Animations
    {
        int counter;

        public Animations()
        {
            counter = 0;
        }

        //This scene shows the characters ready to fight!
        public void skullFightFirstScene()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //line 1
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 1);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 2);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(0, 4);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(0, 5);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 6);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 7);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 8);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 9);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 10);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 11);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("      \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 14);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 16);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 17);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 18);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 19);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 20);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 21);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 22);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                        "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588");
        }

        //This scene shows the characters ready to fight!
        public void skullFightSecondScene()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //line 1
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 1);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 2);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(0, 4);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(0, 5);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 6);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 7);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 8);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 9);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 10);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 11);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("           \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("      \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 14);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 16);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("           \x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 17);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("            \x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 18);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("              \x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2580\x2580"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 19);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 20);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("               \x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 21);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588"); Console.Write("                                                                      "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 22);
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("                    \x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\x2588\x2588"); Console.Write("                                                                        "); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588");
        }

        //This scene shows the characters ready to fight!
        public void IndicatorsPanel()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //line 1
            Console.SetCursorPosition(0, 25);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                         \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 26);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                    \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 27);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("                  \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 28);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(0, 29);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("              \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588");
            Console.SetCursorPosition(0, 30);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 31);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 32);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("          \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 33);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 34);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 35);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
            Console.SetCursorPosition(0, 36);
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("        \x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Black; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\x2588\x2588"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\x2588\x2588\x2588\x2588\x2588\x2588");
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
        public void skullFight()
        {

            //Console.SetWindowSize(300, 300);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Console.Clear();
            //line 1
            while (true)
            {
                
                RefreshCharacters();
                skullFightFirstScene();
                Thread.Sleep(2000);

                RefreshCharacters();
                skullFightSecondScene();
                Thread.Sleep(500);

            }

        }

        public void showIndicators()
        {
            IndicatorsPanel();
        }





        public void Turn(string loadingText)
        {
            Console.SetCursorPosition(loadingText.Length, 0);

            switch (counter % 4)
            {
                case 0: Console.WriteLine("/"); break;
                case 1: Console.WriteLine("-"); break;
                case 2: Console.WriteLine("\\"); break;
                case 3: Console.WriteLine("|"); break;
            }
        }

        public void SequencedMatrix(int row, int column, int width, int height)
        {
            Console.SetCursorPosition(column, row);

            int spot = counter % width;
            int[,] array = new int[width, height];

            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(0); y++)
                {
                    if (y == spot)
                    {
                        Console.Write("[X]");
                        continue;
                    }

                    Console.Write("[ ]");
                }
                Console.WriteLine("");
            }
        }

        public void LoadingBar(string loadingTest, int row, int column)
        {
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

                Console.SetCursorPosition(loadingText.Length + i, row);
                Console.Write("*");
            }
        }

        public void Ready()
        {
            counter++;
            System.Threading.Thread.Sleep(75);
        }
    }




    internal class Program
    {
        const int N = 5;
        const int M = 5;


        static void Main(string[] args)
        {
            /*

            Animations spin = new Animations();
            string loadingText = "Cargando....";
            Console.Write(loadingText);
            Console.CursorVisible = false;

            while (true)
            {
                spin.Turn(loadingText);
                spin.SequencedMatrix(2, 0, 20, 10);
                spin.LoadingBar(loadingText, 23, 0);
                spin.Ready();
            }

            */

          /*  Hero hero = new Hero();
            hero.numPotion = 3;
            hero.name = "myHeroAcademy";
            hero.printPersonalInfo();

            hero.ap = 5;
            hero.attack();
            hero.usePotion();
          */
            Animations showTime = new Animations();
            showTime.skullFight();
            showTime.showIndicators();



            /*
                        Spinner spinner = new Spinner(10, 10);
                          spinner.Start();
                        // Do your work here instead of sleeping...
                          Thread.Sleep(10000);





                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("ThreadProc: {0}", i);
                            // Yield the rest of the time slice.
                            Thread.Sleep(1000);
                        }
            */
            Console.ReadLine();
        }
    }
}
