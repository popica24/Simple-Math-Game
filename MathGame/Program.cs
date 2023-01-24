using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    

    public class MainScreen
    {
        

        public static void StartGame()
        {
            Console.WriteLine("Math Game\n" +
               "Select the operation you want to train\n" +
               "1.Adding\n" +
               "2.Substracting\n" +
               "3.Dividing\n" +
               "4.Multiplying\n\n" +
               "9.View Scoreboard");
        Begin:
            int option = int.Parse(Console.ReadLine());
            string game = string.Empty;
            switch (option)
            {
                case 1:
                    {
                        
                        Console.Clear();
                        Console.WriteLine("Select difficulty :\n" +
                            "Easy -> 1\n" +
                            "Medium -> 2\n" +
                            "Hard -> 3\n");
                        
                        int difficulty = int.Parse(Console.ReadLine());
                        Game.Start(difficulty, '+', "Alex");
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Select difficulty :\n" +
                            "Easy -> 1\n" +
                            "Medium -> 2\n" +
                            "Hard -> 3\n");
                        
                        int difficulty = int.Parse(Console.ReadLine());
                        Game.Start(difficulty, '-', "Alex");
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Select difficulty :\n" +
                            "Easy -> 1\n" +
                            "Medium -> 2\n" +
                            "Hard -> 3\n");
                  
                        int difficulty = int.Parse(Console.ReadLine());
                        Game.Start(difficulty, '/', "Alex");
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Select difficulty :\n" +
                            "Easy -> 1\n" +
                            "Medium -> 2\n" +
                            "Hard -> 3\n");
                     
                        int difficulty = int.Parse(Console.ReadLine());
                        Game.Start(difficulty, '*', "Alex");
                        break;
                    }
                case 9:
                    {
                        Scoring scoring = new Scoring();
                        scoring.DisplayScore("Adding");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Input");
                        goto Begin;
                    }
            }

        }
    }
   
    public class Program
    {
        static void Main(string[] args)
        {
            MainScreen.StartGame();
        }
    }
}