using System;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<string> CustomQueueString = new CustomQueue<string>();
            //CustomQueueInteger.Run();

            CustomQueueString.enqueue("pranav");

            CustomQueueString.enqueue("aditya");

            CustomQueueString.enqueue("klc");

            CustomQueueString.enqueue("wwel");

            //CustomQueueString.sort();
            CustomQueueString.display();



            CustomQueue<float> CustomQueuefloat= new CustomQueue<float>();
            //CustomQueueInteger.Run();

            CustomQueuefloat.enqueue(1.5f);

            CustomQueuefloat.enqueue(9.6f);

            CustomQueuefloat.enqueue(159.2f);

            CustomQueuefloat.enqueue(63.3f);
           
            CustomQueuefloat.display();


            CustomQueue<int> CustomQueueInteger = new CustomQueue<int>();
            //CustomQueueInteger.Run();

              CustomQueueInteger.enqueue(1);

            CustomQueueInteger.enqueue(9);

            CustomQueueInteger.enqueue(159);

            CustomQueueInteger.enqueue(63);

            
            CustomQueueInteger.display();


           


            

            Console.ReadKey();

        }
    }
}
