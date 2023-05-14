using System;
using System.Collections;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
           Queue queue = new Queue();

           

            

            // Adding Element
            Console.WriteLine("Enter Element to Add");
            int iSize = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <  iSize; i++)
            {
                Console.Write("Enter {0}  : ",i+1);
                queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
            }


            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }

            //Remove Element
            
            
            queue.Dequeue();

            Console.WriteLine("Remove operation Perform");


            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }


            //Replace
           

            queue.Clear();






            Console.ReadKey();

        }
    }
}
