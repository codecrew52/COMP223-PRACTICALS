# Bank Account Application

This is a simple command-line application for managing bank accounts. It allows you to:

- Create new accounts
- Login with an existing account
- Make deposits
- Make withdrawals
- Check account balance
- Close accounts
- Logout  

## Usage

To use the application, simply run the executable. You will be presented with a menu to create a new account or login. 

Once logged in, you can perform operations like deposit, withdraw, check balance, etc.

## Implementation Details

The application is implemented in C# using .NET Core.

The main components are:

- `Program` - Contains the main menu logic and calls appropriate functions for each operation
- `Account` - Represents a bank account with balance, account number, username etc.
- `accounts` - A list containing all created accounts
- `loggedInUsers` - A dictionary mapping usernames to accounts for logged in users

The `Account` class encapsulates the account balance and provides methods to deposit/withdraw funds.

### Features

- Account creation with starting balance
- Secure login with username & password
- Deposit money
- Withdraw money (if sufficient balance)
- Check account balance
- Close account
- Logout

### Possible Improvements

Some potential improvements for the future:

- More validation of user input
- Additional account types (checking, savings etc) 
- Transfer money between accounts
- Account statements
- Admin features
- Data persistence using file/database
- Unit tests
- Improved code structuring

## License
No licenses for this project. It is a submission of a class assignment.