using System;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class CustomQueue<T>
    {
        public Node<T> head;

        private int iCnt;

        public void enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (this.head == null)
            {
                this.head = newNode;

                this.iCnt++;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
                this.iCnt++;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0} is added into Queue", newNode.data);
            Console.ResetColor();

        }

        public void display()
        {
            Node<T> temp = this.head;

            if (temp == null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tQueue is Empty");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.Write("Head-");
                while (temp != null)
                {
                    Console.Write(" {0} -> ", temp.data);
                    temp = temp.next;
                }
                Console.WriteLine("-NULL");
            }
        }


        public void dequeue()
        {
            Node<T> temp = this.head;

            if (temp == null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tQueue is Empty");
                Console.ResetColor();
                return;
            }
            else if (temp.next == null)
            {
                this.head = null;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tDequeue is Successfully Done ");
                Console.ResetColor();
                iCnt--;
            }
            else
            {
                while ((temp.next).next != null)
                {
                    temp = temp.next;
                }

                temp.next = null;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tDequeue is Successfully Done ");
                Console.ResetColor();
                iCnt--;
            }
        }

        public void isEmpty()
        {
            if (this.head == null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tQueue is Empty");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tQueue is NOT Empty");
                Console.ResetColor();
            }
        }

        public void size()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\tQueue having {0} Elements. ", this.iCnt);
            Console.ResetColor();
        }


        public void Run()
        {
            Random random = new Random();

            dynamic iNo, iCnt = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("*************************************************");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\t\tWEL-COME TO QUEUE");
                Console.ResetColor();
                Console.WriteLine("*************************************************");
                Console.WriteLine("\t----------OPTIONS----------\n");
                Console.WriteLine("1  : Enqueue in Queue");
                Console.WriteLine("2  : Display Queue");
                Console.WriteLine("3  : Dequeue in Queue");
                Console.WriteLine("4  : IS-Empty Queue");
                Console.WriteLine("5  : Size of Queue");
                Console.WriteLine("0  : Exit\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("********************************************");
                switch (option)
                {
                    case 1:

                        Console.Write("----------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("ENQUEUE");
                        Console.ResetColor();
                        Console.Write(" }----------\n\n");

                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            iNo = random.Next(9, 99);
                            Console.Write("\nEnter {0} Element : ", i + 1);
                            enqueue(iNo);
                        }
                        Console.WriteLine("\n--------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("----------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("DISPLAY QUEUE");
                        Console.ResetColor();
                        Console.Write(" }----------\n\n");

                        display();

                        Console.WriteLine("\n-----------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 3:

                        Console.Write("----------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("DEQUEUE");
                        Console.ResetColor();
                        Console.Write(" }----------\n\n");

                        dequeue();

                        Console.WriteLine("\n-----------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 4:

                        Console.Write("----------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("IS-EMPTY");
                        Console.ResetColor();
                        Console.Write(" }----------\n\n");

                        isEmpty();

                        Console.WriteLine("\n-----------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 5:

                        Console.Write("----------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("SIZE OF QUEUE");
                        Console.ResetColor();
                        Console.Write(" }----------\n\n");

                        size();

                        Console.WriteLine("\n-----------------------------------");


                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;


                    case 0:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Please enter right option");
                        break;

                }
            }

        }
    }
}
