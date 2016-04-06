

/*
 * Ahmad Khan
 * Spring 2014- C# class
 * Seminar two program
 * Date May 26 , 2014
 * 
 * Seminar One Programming Assignment
 * 
 * 
 * an Object that behaves as a DIE.
 * 
 * */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxCars
{



    class die
    {


        // Dice Range of Max 6
        private const int MAX = 6;


        // Holds the facevalue of the die
        private int faceValue;

        
        // and object of random
        private Random generator;


        public die()
        {

            ///  initiate and ojbect in the constructor 
            generator = new Random(DateTime.Now.Millisecond);
            faceValue = 1;

        }


        // Roll the dice and return faceValue
        public int Roll() 
        {

            faceValue = generator.Next(MAX) + 1;
            return faceValue;
        
        }


        // to string method
        public override string ToString()
        {
            return faceValue.ToString();


        }



        /// <summary>
        ///  public proprity method
        /// </summary>
        public int FaceValue
        {

            get {

                return faceValue;
            }
        
        
        }
    }
}
