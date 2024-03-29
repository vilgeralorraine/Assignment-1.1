using System;
using System.ComponentModel;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args) 
        {
            int attempt = 3;
            while (attempt > 0)
            {
                Console.Write("Type your Username: ");
                string Username = Console.ReadLine();

                Console.Write("Type your Password: ");
                string Password = Console.ReadLine();

                if (Username == "Admin" && Password == "Admin1234!")
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    attempt--;
                    Console.Clear();//
                    Console.WriteLine("Incorrect Credentials! Remaining attempts:" + attempt);
                }
            }

            if (attempt == 0)
            {
                Console.WriteLine("You have run out of attempts! Access denied.");
            }
        }
    }
}