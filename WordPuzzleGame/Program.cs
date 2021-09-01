using System;

namespace WordPuzzleGame
{
    class Game
    {

       
        String input="";
        int Score = 0;
        string[] Words = new string[] { 
                                           "TAE","TEA","EMS","ERA","TAR" , "TAM", "ATE"  ,"EAT","ARE",
                                         "EAR","ARM","ART", "TAS", "ERS","ARS","MAR","RET","RAM",
                                          "RES","REM", "MAS","MAT", "MET","RAT","RAS","SAE","SAT",
                                           "SET","SER","ETA","TER", "AMT",  "EMA","SEA","MAE"
                                               };

        public static void Ruth(int n)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= n; i++)
            {
                switch (i)
                {
                    
                    case 0:
                       
                        Console.WriteLine("\t");
                        Console.WriteLine("--------WelCome To PUZZLE GAME----------------");
                        Console.WriteLine("\t");
                        break;
                    case 1:
                        
                        Console.WriteLine("1.Read all The Instruction");
                        break;
                    case 2:
                        
                        Console.WriteLine("2.Please enter the words in uppercase");
                        break;
                    case 3:
                        
                        Console.WriteLine("3.Every correct word will add 1 point to your score");
                        break;
                    case 4:
                       
                        Console.WriteLine("4.Enter The Words From MASTER");
                        break;
                    case 5:
                       
                        Console.WriteLine("5.In Order to Restart The Game Press Contintue.");
                        Console.Write("___________________________________________________________");
                        break;
                    default:
                        Console.WriteLine("Thank you For play");
                        break;
                }
            }
        }


        public void play()
        {
            Console.WriteLine("\t");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
          

            Console.WriteLine("Enter The Combination Of Three Words Using MASTER :");
            Console.Write("ENTER THE WORDS :");
            input = Console.ReadLine();

          
                Console.WriteLine();
                int pos = Array.IndexOf(Words, input);
            string ans = Console.ReadLine();
                    
                if (pos > -1)
                {
                do
                {
                    
                        Console.WriteLine("Whoo ! You Guess Right");
                        Score++;
                       Console.WriteLine("Do You Wish To Exit");
                     
                      }
                while (ans!="Quit");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your SCORE." + Score + " Try again!");
                     Console.WriteLine("Press enter to continue...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    play();
                }
           
               

            

            }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Game.Ruth(5);
            Game g1 = new Game();




            Console.WriteLine("\t");
            g1.play();
            Console.ReadKey();
        }
    }
  }
       

        
