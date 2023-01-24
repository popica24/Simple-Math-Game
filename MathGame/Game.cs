using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathGame
{
    public class Game
    {
        public static void Start(int Difficulty,char Opperator,string User)
        {
            var score = 0;
            Console.Clear();
            Random random = new Random();
            var username = Console.ReadLine();
            Start:
          
                switch (Opperator)
                {
                    case '+':
                        {
                            switch (Difficulty)
                            {
                                case 1:
                                    {
                                        var a = random.Next(0, 10);
                                        var b = random.Next(0, 10);
                                        Console.WriteLine(a+"+"+b+"=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a + b)
                                        {
                                            score += 10;
                                            goto Start;                   
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                    Scoring scoring = new Scoring();
                                    scoring.Add(username, score, "Adding");
                                    Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                                case 2:
                                    {
                                        var a = random.Next(10,99);
                                        var b = random.Next(10, 99);
                                        Console.WriteLine(a + "+" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a + b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                                case 3:
                                    {
                                        var a = random.Next(100, 1000);
                                        var b = random.Next(100, 1000);
                                        Console.WriteLine(a + "+" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a + b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                            }
                            break;
                        }
                    case '-':
                        {
                            switch (Difficulty)
                            {
                                case 1:
                                    {
                                        var a = random.Next(0, 10);
                                        var b = random.Next(0, 10);
                                        Console.WriteLine(a + "-" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a - b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                                case 2:
                                    {
                                        var a = random.Next(10, 99);
                                        var b = random.Next(10, 99);
                                        Console.WriteLine(a + "-" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a - b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                                case 3:
                                    {
                                        var a = random.Next(100, 1000);
                                        var b = random.Next(100, 1000);
                                        Console.WriteLine(a + "-" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a - b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                            }
                            break;
                        }
                    case '*':
                        {
                            switch (Difficulty)
                            {
                                case 1:
                                    {
                                        var a = random.Next(0, 10);
                                        var b = random.Next(0, 10);
                                        Console.WriteLine(a + "*" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a * b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                                case 2:
                                    {
                                        var a = random.Next(10, 99);
                                        var b = random.Next(10, 99);
                                        Console.WriteLine(a + "*" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a * b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                                case 3:
                                    {
                                        var a = random.Next(100, 1000);
                                        var b = random.Next(100, 1000);
                                        Console.WriteLine(a + "*" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a * b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                            }
                            break;
                        }
                    case '/':
                        {
                            switch (Difficulty)
                            {
                                case 1:
                                    {
                                        var a = random.Next(0, 10);
                                        var b = random.Next(0, 10);
                                        Console.WriteLine(a + "/" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a / b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                                case 2:
                                    {
                                        var a = random.Next(10, 99);
                                        var b = random.Next(10, 99);
                                        Console.WriteLine(a + "/" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a / b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                                case 3:
                                    {
                                        var a = random.Next(100, 1000);
                                        var b = random.Next(100, 1000);
                                        Console.WriteLine(a + "/" + b + "=");
                                        if (int.Parse(Console.ReadLine().Trim()) == a / b)
                                        {
                                            score += 10;
                                            goto Start;
                                        }
                                        Console.Clear();
                                        Console.WriteLine(username + "-" + score);
                                        Thread.Sleep(100);
                                        MainScreen.StartGame();
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
        
    }
}
