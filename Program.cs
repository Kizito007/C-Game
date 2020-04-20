using System;

namespace Task
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            //Variables
            int levelPick= 0;
            int trial= 6;
            int tries= 4;
            int tryy= 3;
            Random rnd= new Random();
            int easy= rnd.Next(1, 10);
            int medium= rnd.Next(1, 20);
            int hard= rnd.Next(1, 50);
            int guess= 0;

            //Intro          
            Console.WriteLine("*===== Welcome to my number guessing game =====*");
            Console.WriteLine("\nThere are 3 levels: 1-Easy, 2-Medium & 3-Hard\n  ");
            Console.Write("Pick level Number: ");
            levelPick= int.Parse(Console.ReadLine());

            //LEVEL CONDITIONING 
            if (levelPick == 1)
            {
                    //////////////////////LEVEL EASY/////////////////////////////
                for (int i = 0; i < trial; i++)
                {   
                    //NO OF GUESSES LEFT
                    int guessesLeft= 5 - i;
                    Console.Write("Enter guess No from 1- 10: ");
                    //GETTING CORRECT GUESS
                    guess= int.Parse(Console.ReadLine());
                    if (guess != easy)
                    {
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have "+ guessesLeft + " guess");
                            if (guessesLeft == 0)
                            {
                                Console.WriteLine("Game over!");
                            }
                    }
                    else
                    {
                        Console.WriteLine("You got it right!");
                        break;
                    } 
                }
                //NEXT LEVEL
            }else if (levelPick == 2)
            {
                ///////////////////////////////LEVEL MEDIUM////////////////////////
                for (int i = 0; i < tries; i++)
                {   
                    int guessesLeft= 3 - i;
                    Console.Write("Enter guess No from 1- 20: ");
                    guess= int.Parse(Console.ReadLine());
                    if (guess != medium)
                    {
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have "+ guessesLeft + " guess");
                            if (guessesLeft == 0)
                            {
                                Console.WriteLine("Game over!");
                            }
                    }
                    else
                    {
                        Console.WriteLine("You got it right!");
                        break;
                    } 
                } 
            }else if (levelPick == 3)
            {
                ///////////////////////////////LEVEL HARD//////////////////////////////
                for (int i = 0; i < tryy; i++)
                {   
                    int guessesLeft= 2 - i;
                    Console.Write("Enter guess No from 1- 50: ");
                    guess= int.Parse(Console.ReadLine());
                    if (guess != hard)
                    {
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have "+ guessesLeft + " guess");
                        if (guessesLeft == 0)
                        {
                            Console.WriteLine("Game over!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You got it right!");
                        break;
                    } 
                } 
            }else
            {
                Console.WriteLine("\nThere are 3 levels: 1-Easy, 2-Medium & 3-Hard\n  ");
            }  
        }
    }
}
