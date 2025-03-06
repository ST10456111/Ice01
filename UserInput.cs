using System;

namespace Ice01
{
    internal class UserInput
    {
        private string name;
        private string number; // Changed to string to preserve leading zeros
        private int age;

        //-----------------------------------------------------------------------------------//
        // Method to process the user's choice and perform the corresponding action
        public void ProcessChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    // Prompt the user to enter their name
                    Console.WriteLine("What is your name?");
                    name = Console.ReadLine();
                    break;
                case 2:
                    // Prompt the user to enter their cell number
                    Console.WriteLine("Enter your cell number");
                    number = Console.ReadLine(); // Read as string to preserve leading zeros
                    break;
                case 3:
                    // Prompt the user to enter their age
                    Console.WriteLine("Enter your age");
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        // Successfully parsed age
                    }
                    else
                    {
                        // Handle invalid age input
                        Console.WriteLine("Invalid age. Please enter a valid integer.");
                    }
                    break;
                case 4:
                    // Print the summary of the user's details
                    Console.WriteLine($"Name: {name}\nNumber: {number}\nAge: {age}");
                    break;
                default:
                    // Handle invalid choice input
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
//----------------------------EOF-------------------------------------//
