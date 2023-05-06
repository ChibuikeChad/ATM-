# ATM Project Documentation

## Overview

The ATM (Automated Teller Machine) project is a simple console-based application written in C#. It simulates the functionalities of an ATM machine, allowing users to perform basic operations such as checking account balance, withdrawing funds, and transferring funds to another account.

The project provides a user-friendly interface where users can enter their PIN, navigate through a main menu, and select the desired operation. It incorporates input validation to ensure data integrity and provides appropriate feedback messages to the users.

## Features

The ATM project offers the following features:

1. PIN Verification: Users are prompted to enter their PIN to access the main menu. If an incorrect PIN is entered, the system displays an error message and allows the user to retry.

2. Check Balance: Users can select the "Check Balance" option from the main menu to view their current account balance.

3. Withdraw Funds: Users can choose the "Withdraw Funds" option to initiate a withdrawal. They are prompted to enter the withdrawal amount, and the system checks if sufficient funds are available before deducting the amount from the account balance.

4. Transfer Funds: Users can select the "Transfer Funds" option to transfer money to another account. They are asked to enter the transfer amount, the account number of the recipient, and select the recipient's bank from a predefined list. The system validates the transaction and deducts the transfer amount from the account balance if sufficient funds are available.

5. Exit: Users can choose the "Exit" option to terminate the ATM application.

## Getting Started

To run the ATM project, follow these steps:

1. Ensure that you have a C# development environment set up. This can be Visual Studio, Visual Studio Code with the .NET Core SDK, or any other compatible IDE.

2. Create a new C# console application project.

3. Replace the default code in the `Program.cs` file with the provided ATM project code.

4. Build and run the application.

5. Follow the instructions displayed on the console to interact with the ATM simulation. Enter the PIN, navigate the main menu, and choose the desired options.

## Code Structure

The ATM project code is structured as follows:

- The `Program` class contains the main entry point of the application. It handles the user interaction and performs the necessary operations based on user input.

- The `Main` method is responsible for displaying the welcome message, verifying the PIN, and presenting the main menu to the user.

- The main menu provides options for checking the account balance, withdrawing funds, transferring funds, and exiting the program.

- Each menu option has its corresponding code block that executes the specific functionality.

- The project utilizes loops to ensure continuous interaction until the user chooses to exit.

## Limitations and Future Enhancements

The current implementation of the ATM project has the following limitations:

1. Lack of persistent data storage: The project does not incorporate any data storage mechanism to persist user account details or transaction history. Each time the program runs, it starts with the initial balance and PIN.

2. Limited error handling: While basic error handling is implemented, the project does not extensively handle all possible edge cases or exceptions. Enhancements can be made to provide more robust error handling and graceful error messages.

3. Lack of user account management: The project does not include features for creating or managing user accounts. It assumes a single user account with a predefined PIN and balance.

To further enhance the project, you can consider implementing the following features:

- Integrate a database or file system to store user account details and transaction history.

- Implement a user registration and login system with proper authentication and authorization.

- Add additional security measures, such as PIN encryption and validation rules.

- Provide more advanced transaction options, such as depositing funds or viewing transaction history
