/*
    Programa realizado por Alejandro Vaquera Lopez
    Proyecto final para la materia "Programacion en c# .NET"
    Segundo Cuatrimestre 2do bloque
    22/08/2023
    A jugar!
 */

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
            string[] completeName = new string[2];

            int[] enemyArray = new int[8];

            SoundPlayer musicPlayer = new SoundPlayer();
            Random randomGenerator = new Random();

            //initial values
            Hero hero = new Hero();
            hero.name = "Juanito";
            hero.secondName = "Lechuga";
            hero.hp = randomGenerator.Next(1, 6);
            hero.ap = randomGenerator.Next(1, 3);
            hero.numGun = 0;
            hero.numHelmet = 0;
            hero.numArmor = 0;
            hero.numPotion = 0;
            hero.x = 1;
            hero.y = 1;

            Enemy enemy = new Enemy();
            enemy.name = "El";
            enemy.secondName = "Cucui";
            enemy.hp = 2;
            enemy.ap = 1;


            Animations showTime = new Animations(hero.name, hero.secondName, enemy.name, enemy.secondName, hero.hp, enemy.hp, hero.ap, enemy.ap);

            Map firstLevel = new Map();
            //Print selectable menu
            int menuOpc = showTime.MenuScene();

            //Ask the name of hero
            completeName = showTime.PlayerName();
            hero.name = completeName[0];
            hero.secondName = completeName[1];

            showTime.Warning("Expand your console window to FULL SCREEN for better experience!");

            if (menuOpc == 0) //player selected "Play" option
            {
                showTime.ExecLoadingBar("Generating map", 150);
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
                                victory = true;
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
                        for (int cont = 0; cont < 8; cont += 2)
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
                                        else if (enemy.hp <= 0)
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
                    musicPlayer.Stop();
                    musicPlayer.SoundLocation = "Game-Over-8-bit.wav";
                    musicPlayer.Play();
                    showTime.GameOver();
                }
                else if (victory)
                {
                    musicPlayer.Stop();
                    musicPlayer.SoundLocation = "Victory-8-bit.wav";
                    musicPlayer.Play();
                    showTime.VictoryScene();
                }

                Console.Clear();
                Console.WriteLine("Level 2 coming soon.....!");
            }
            else //player selected "Credits" option
            {
                showTime.VictoryScene();
            }
            
            Console.ReadLine();
        }
    }
}
