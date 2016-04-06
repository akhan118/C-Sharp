/*
 * Ahmad Khan
 * 
 * June 18-2014
 * 
 * S5- Programming assigment
 * 
 * C# course;
 * 
 * 
 * */






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {

            char Value = 'a';
            char twoLines='b';


            NodeList line = new NodeList();


            line.Add(Value);
            line.Add(twoLines);

            Console.Out.WriteLine(line);

            Console.In.Read();



                 


        }
    }
}
