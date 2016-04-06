/*
 * Ahmad Khan
 * Spring 2014- C# class
 * Seminar 3 program
 * Date June 4 , 2014
 * 
 * a Guessing game that take a number and tell you if it's close or not
 * 
 * */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hi_Low
{
    class Program
    {
        static void Main(string[] args)
        {


        Random generator;
        int randomNum;


        Boolean Flag = true;
        generator = new Random(DateTime.Now.Millisecond);
        randomNum = generator.Next(1, 100);
        int count = 1;

        
           /// going into loop the flag set above 
            while (Flag) {

            count++;

            int input;
            int PlayOrQuit;
         

            Console.Out.WriteLine("for Demo purpose the number is " + randomNum + " shhh....");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Guess the Number Or enter 200 anytime in the game to quit");


            //read

            input =int.Parse( Console.In.ReadLine());


//// function to see if the input = the random number


                // if correct say so
           if (checkInput(input, randomNum))
            {

               
                Console.Out.WriteLine("Correct!!!! and it had taken " + count + " guesses ");
                Console.Out.WriteLine("Enter 200 to quit or press 300 to play");

                PlayOrQuit = int.Parse(Console.In.ReadLine());

               /// if they want to play, then play
                if (PlayOrQuit == 300) {

                    randomNum = generator.Next(1, 100);
                
                }

               /// if they want to quit then quit
                if (PlayOrQuit == 200)
                {

                    Flag = false;
                
                }


            }
            else

            {


           

               //// check if it's hot or cold
                if (input < (randomNum - 10) || input > (randomNum + 10))
                {

                    Console.Out.WriteLine("You are too Cold");
                    Console.Out.WriteLine("Try Again");
                }

                else {

                    Console.Out.WriteLine("You warm ");
                    Console.Out.WriteLine("Try Again");

                }

            
            
            }


  
        
        
        
        
        }


          





        }







   // function to compare
        static Boolean  checkInput(int input , int random)

        {

            
                    if (input == random)
            {

               return true ;

            }
            else {

              return false;
            
            }
        
        }
    }
}
