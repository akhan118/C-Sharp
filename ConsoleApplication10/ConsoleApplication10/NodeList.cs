using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class NodeList
    {

        private node list;

        public NodeList()
        {

            list = null;

        }


        public void Add(char CharInput)
        {

            node NodeObject = new node(CharInput);

            node current;

            if (list == null)
            {

                list = NodeObject;

            }
            else
            {

                current = list;

                while (current.next != null)
                {

                    current = current.next;
                    current.next = NodeObject;

                }
            }



        }


        public override String ToString()
        {
            string result = "";
            char singleChar;

            node current = list;

            while (current != null)
            {

                singleChar = current.CharX;
                result += current.CharX.ToString();


                current = current.next;



            }

            return result;
        }



    }




    class node
    {


        public char CharX;
        public node next;


        public node(char CharInput)
        {

            CharX = CharInput;
            next = null;



        }
    }


}
