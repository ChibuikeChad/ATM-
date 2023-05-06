using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            decimal balance = 1000.00m; // Initial balance
            decimal withdrawalAmount;
            string pin = "1234"; // Initial PIN

            // Welcome message
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("");
            Console.WriteLine("Enter your PIN to get started:");

            // Get user input for PIN
            string enteredPin = Console.ReadLine();

            // Check if entered PIN is correct
            while (enteredPin != pin)
            {
                Console.WriteLine("Incorrect PIN. Please try again.");

                // Get user input for PIN
                enteredPin = Console.ReadLine();
            }

            // PIN is correct, display main menu
            while (enteredPin == pin)
            {
                Console.WriteLine("");
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Funds");
                Console.WriteLine("3. Transfer Funds");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter a choice:");

                // Get user input for menu selection
                int selection = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                // Check user selection and perform action
                switch (selection)
                {
                    case 1:
                        // Display balance
                        Console.WriteLine("Your current balance is: $" + balance);
                        break;
                    case 2:
                        // Get withdrawal amount from user
                        Console.WriteLine("Enter withdrawal amount:");
                        withdrawalAmount = decimal.Parse(Console.ReadLine());

                        // Check if sufficient funds are available
                        if (withdrawalAmount > balance)
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        else
                        {
                            // Deduct withdrawal amount from balance
                            balance -= withdrawalAmount;
                            Console.WriteLine("Withdrawal successful. Your new balance is: $" + balance);
                        }
                        break;
                    case 3:
                        // Get withdrawal amount from user
                        Console.WriteLine("Enter transfer amount:");
                        decimal transferAmount = decimal.Parse(Console.ReadLine());

                        // Get account number from user
                        Console.WriteLine("Enter account number:");
                        int accountNumber = int.Parse(Console.ReadLine());

                        // Get transfer bank from user
                        Console.WriteLine("Bank List");

                        Console.WriteLine("1. First Bank");
                        Console.WriteLine("2. Zenith Bank");
                        Console.WriteLine("3. United Bank for Africa (UBA)");
                        Console.WriteLine("4. Access Bank");
                        Console.WriteLine("");
                        Console.WriteLine("Enter Bank:");
                        
                        int bank = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        // Check if sufficient funds are available
                        if (transferAmount > balance)
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        else
                        {
                            // Deduct transfer amount from balance
                            balance -= transferAmount;
                            Console.WriteLine("Transfer successful. You transferred $" + transferAmount + ". Your new balance is: $" + balance);
                        }
                        break;
                    case 4:
                        // Exit program
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        return;
                    default:
                        // Invalid selection
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
        }
    }
}