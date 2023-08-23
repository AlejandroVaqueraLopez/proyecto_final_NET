using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_rpg
{

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
                if (DetectItem(this.discoveredMap[row, (col - 1)]))
                {
                    enemiesFound++;
                    enemiesPositions[++count] = row;
                    enemiesPositions[++count] = (col - 1);
                }
            }
            //(-,col) UP
            if ((row - 1) > 0)
            {
                if (DetectItem(this.discoveredMap[(row - 1), col]))
                {
                    enemiesFound++;
                    enemiesPositions[++count] = row - 1;
                    enemiesPositions[++count] = col;
                }
            }

            //(row,+) RIGHT
            if ((col + 1) < M)
            {
                if (DetectItem(this.discoveredMap[row, col + 1]))
                {
                    enemiesFound++;
                    enemiesPositions[++count] = row;
                    enemiesPositions[++count] = col + 1;
                }
            }

            //(+,col) DOWN
            if ((row + 1) < N)
            {
                if (DetectItem(this.discoveredMap[(row + 1), col]))
                {
                    enemiesFound++;
                    enemiesPositions[++count] = row + 1;
                    enemiesPositions[++count] = col;
                }
            }

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
            if ((col - 1) > 0) { this.discoveredMap[row, (col - 1)] = this.originalMap[row, (col - 1)]; }

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

            Console.ForegroundColor = ConsoleColor.DarkGray;

            for (int row = 0; row < N; row++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, (Console.WindowHeight / 2 - 3) + row);
                for (int col = 0; col < M; col++)
                {
                    switch (discoveredMap[row, col])
                    {
                        case "L": //wall
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\x2588");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "S": //Entrance
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\x0305");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "E": //Enemy
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\x25A0");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
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
                            Console.Write("\x25A0");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "W": //Gun
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("\x25A0");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "A": //Armor
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("\x25A0");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "F": //Exit
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\x0305");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "P": //Potion
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("\x25A0");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "\x25A0": //Hero
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\x25A0");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
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


}
