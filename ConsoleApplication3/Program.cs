
/*
 * Ahmad Khan
 * Spring 2014- C# class
 * Seminar two program
 * Date May 26 , 2014
 * 
 * Seminar One Programming Assignment
 * 
 * 
 * an Object that call a another object and loop a 1000 times to find how many BoxCars in a 1000 roll
 * 
 * */







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxCars
{
    class BoxCars
    {
        static void Main(string[] args)
        {


        die    pairOfDice1 = new die();
        die    pairOfDice2 = new die();

            /// set the number of rolls
            int count = 1000;

            // set the number of boxCars to zero
            int NumberOfBoxCars = 0;


            // Loop a 1000 times
            for (int i = 0; i < count; i++)

            {
                pairOfDice1.Roll();
                pairOfDice2.Roll();

                /// return the Facevalue of each die and see if they both = 6
                if (pairOfDice1.FaceValue == 6 & pairOfDice2.FaceValue == 6)
                {

                    /// count how many BoxCars and keep track of it
                    NumberOfBoxCars++;

                }
            }

            /// print out the number of BoxCars

            Console.Out.WriteLine("The Number of BoxCars in a 1000 roles is  " +NumberOfBoxCars);
            Console.In.Read();

        }
    }
}
