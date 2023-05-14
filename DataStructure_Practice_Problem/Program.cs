using System;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> CustomStackString = new CustomStack<string>();
            //CustomStackInteger.Run();

            CustomStackString.push("pranav");

            CustomStackString.push("aditya");

            CustomStackString.push("klc");

            CustomStackString.push("wwel");

            //CustomStackString.sort();
            CustomStackString.display();



            CustomStack<float> CustomStackfloat= new CustomStack<float>();
            //CustomStackInteger.Run();

            CustomStackfloat.push(1.5f);

            CustomStackfloat.push(9.6f);

            CustomStackfloat.push(159.2f);

            CustomStackfloat.push(63.3f);
            CustomStackfloat.sort();
            CustomStackfloat.display();


            CustomStack<int> CustomStackInteger = new CustomStack<int>();
            //CustomStackInteger.Run();

              CustomStackInteger.push(1);

            CustomStackInteger.push(9);

            CustomStackInteger.push(159);

            CustomStackInteger.push(63);

            //CustomStackInteger.sort();
            CustomStackInteger.display();


           


            

            Console.ReadKey();

        }
    }
}
