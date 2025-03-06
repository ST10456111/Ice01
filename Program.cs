using System;

namespace Ice01
{
    internal class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // Create a single instance of UserInput to store user details
            UserInput user = new UserInput();

            // Create an instance of UserInputHandler to handle user input and pass the UserInput instance to it
            UserInputHandler handler = new UserInputHandler(user);

            // Call the Run method to start the menu and handle user input
            handler.Run();
        }
    }
}
//----------------------------EOF-------------------------------------//
