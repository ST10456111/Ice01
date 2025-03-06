using System;

namespace Ice01
{
    internal class UserInputHandler
    {
        private readonly UserInput userInput;

        // Constructor to initialize UserInputHandler with a UserInput instance
        public UserInputHandler(UserInput userInput)
        {
            this.userInput = userInput;
        }

        // Method to run the menu that prompts the user to enter their details
        public void Run()
        {
            do
            {
                // Display menu options to the user
                Console.WriteLine("Press F1 to enter name");
                Console.WriteLine("Press F2 to enter cell number");
                Console.WriteLine("Press 3 to enter age");
                Console.WriteLine("Press 4 to print summary of details");
                Console.WriteLine("Press 5 to exit program");

                // Read the key pressed by the user
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                int choice = 0;

                // Determine the choice based on the key pressed
                switch (keyInfo.Key)
                {
                    case ConsoleKey.F1:
                        choice = 1; // F1 for entering name
                        break;
                    case ConsoleKey.F2:
                        choice = 2; // F2 for entering cell number
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        choice = 3; // 3 for entering age
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        choice = 4; // 4 for printing summary of details
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        choice = 5; // 5 for exiting the program
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please press a valid key.");
                        continue; // Continue the loop if an invalid key is pressed
                }

                // Exit the loop if choice is 5
                if (choice == 5)
                {
                    break;
                }

                // Process the user's choice
                userInput.ProcessChoice(choice);

            } while (true); // Continue the loop until the user chooses to exit
        }
    }
}
//----------------------------EOF-------------------------------------//
