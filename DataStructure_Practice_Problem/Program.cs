using System;
using System.Collections;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
           Stack stack = new Stack();

           

            

            // Adding Element
            Console.WriteLine("Enter Element to Add");
            int iSize = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <  iSize; i++)
            {
                Console.Write("Enter {0}  : ",i+1);
                stack.Push(Convert.ToInt32(Console.ReadLine()));
            }


            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            //Remove Element
            
            
            stack.Pop();

            Console.WriteLine("Remove operation Perform");


            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }


            //Replace
           

            stack.Clear();






            Console.ReadKey();

        }
    }
}
