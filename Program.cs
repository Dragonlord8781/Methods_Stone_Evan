using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asks for name
            Console.WriteLine("Please enter name.");
            //initalises the string userName with the inputted name
            string userName = Console.ReadLine();
            //activates Introduction
            Introduction(userName);
            // writes a line give a space inbetween Introduction and Donadogohvi
            Console.WriteLine("...");
            // actuvates Donadogohvi
            Donadogohvi();
        }
        //creates introduction with factor of string userName
        static void Introduction(string userName)
        {
            //writes line on activation, with userName as a component, greeting the user
            Console.WriteLine($"Hello, {userName}! It is nice to meet you!");
        }
        //creates Donadogohvi
        static void Donadogohvi()
        {
            //writes line telling the user to have a fantastic day
            Console.WriteLine("Have a fantastic day!");
        }
    }
}