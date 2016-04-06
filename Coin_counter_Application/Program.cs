
/*
 * Ahmad Khan
 * Spring 2014- C# class
 * Seminar One Exercises
 * Date May 18 , 2014
 * 
 * Seminar One Programming Assignment
 * Do Programming Project 2.8 located on pg. 104 in the text.
 * 
 * An Application that take the number of coins and ouput the total in dollar and cent
 * 
 * */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coin_counter_Application
{
    /// <summary>
    ///  A class that reads an input as the number of coines and output the total .
    /// </summary>
    class Coin_Jar
    {



        static void Main(string[] args)
        {

            double myTotal;
            double quarters;
            double dimes;
            double nickles;
            double pennies;


            Console.Out.WriteLine(" Count the Coin in the Jar");
            Console.Out.WriteLine("Enter the number of Quarters ");

            // casting the input as a double and then multiply it by the domaination of the coin
            quarters = double.Parse(Console.In.ReadLine());
            quarters = quarters * .25;


            Console.Out.WriteLine("Enter the number of dimes  ");
            dimes = double.Parse(Console.In.ReadLine());
            dimes = dimes * .10;

            Console.Out.WriteLine("Enter the number of Nickles  ");
            nickles = double.Parse(Console.In.ReadLine());
            nickles = nickles * .05;

            Console.Out.WriteLine("Enter the number of Pennies  ");
            pennies = double.Parse(Console.In.ReadLine());
            pennies = pennies * .01;

            // Summing the coins
            myTotal = quarters + dimes + nickles + pennies;

            /// Ouputing the total as a string
            Console.Out.WriteLine("Total in Dollar and Cent " + myTotal.ToString("c"));
            Console.In.ReadLine();

        }
    }
}
