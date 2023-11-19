using System;
using System.Collections.Generic;

namespace BankAccountApp 
{
    class Program
    {
        static Dictionary<string, Account> loggedInUsers = new Dictionary<string, Account>();
        static List<Account> accounts = new List<Account>();
        
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Bank Account Management");
                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Login");
                Console.WriteLine("0. Exit");
                
                Console.Write("Select an option: ");
                int choice = int.Parse(Console.ReadLine());
                
                if (choice == 1) {
                    CreateAccount();
                }
                else if (choice == 2) {
                    Login(); 
                }
                else if (choice == 0) {
                    Console.WriteLine("Exiting program...");
                    break; 
                }
            }
        }

        static void CreateAccount() {
            Console.WriteLine("Creating a new account...");
            int accountNumber = accounts.Count + 1;
            Console.Write("Enter initial balance: ");
            decimal initialBalance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Account newAccount = new Account(accountNumber, initialBalance, username, password);
            accounts.Add(newAccount);

            Console.WriteLine($"Account created successfully! Account Number: {accountNumber}");
        }

        static void Login() {
            Console.WriteLine("Login...");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Account account = accounts.Find(acc => acc.Username == username && acc.Password == password);

            if (account != null) {
                Console.WriteLine("Login successful!");
                loggedInUsers[username] = account;
                MainMenu();
            }
            else {
                Console.WriteLine("Invalid username or password.");
            }
        }

        static void MainMenu() {
            while (true) {
                Console.WriteLine("Logged-in Menu");
                Console.WriteLine("1. Make Deposit");
                Console.WriteLine("2. Make Withdrawal");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Close Account");
                Console.WriteLine("5. Logout");
                Console.Write("Select an option: ");
                int choice = int.Parse(Console.ReadLine());
              
                if (choice == 1) {
                    MakeDeposit(); 
                }
                else if (choice == 2) {
                    MakeWithdrawal();
                }
                else if (choice == 3) {
                    CheckBalance();
                }
                else if (choice == 4) { 
                    CloseAccount();
                }
                else if (choice == 5) {
                    Console.WriteLine("Logging out...");
                    Console.WriteLine("You have been logged out successfully!");
                    break;
                }
            }
        }

        static void MakeDeposit() {
            Console.WriteLine("Making a deposit...");
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Account account = accounts.Find(acc => acc.AccountNumber == accountNumber);

            if (account != null && loggedInUsers.ContainsValue(account)) {
                Console.Write("Enter deposit amount: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());
                account.Deposit(depositAmount);

                Console.WriteLine($"Deposit successful! New balance: {account.Balance}");
            }
            else {
                Console.WriteLine("Invalid account or not logged in!");
            }
        }

        static void MakeWithdrawal() {
            Console.WriteLine("Making a withdrawal...");
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Account account = accounts.Find(acc => acc.AccountNumber == accountNumber);

            if (account != null && loggedInUsers.ContainsValue(account)) {
                Console.Write("Enter withdrawal amount: ");
                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                if (account.Balance >= withdrawalAmount) {
                    account.Withdraw(withdrawalAmount);
                    Console.WriteLine($"Withdrawal successful! New balance: {account.Balance}");
                }
                else {
                    Console.WriteLine("Insufficient funds!");
                }
            }
            else {
                Console.WriteLine("Invalid account or not logged in!");
            }
        }

        static void CloseAccount() {
            Console.WriteLine("Closing an account...");
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Account account = accounts.Find(acc => acc.AccountNumber == accountNumber);

            if (account != null && loggedInUsers.ContainsValue(account)) {
                accounts.Remove(account);
                Console.WriteLine($"Account closed successfully!");
            }
            else {
                Console.WriteLine("Invalid account or not logged in!");
            }
        }

        static void CheckBalance() {
            Console.WriteLine("Checking account balance...");
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Account account = accounts.Find(acc => acc.AccountNumber == accountNumber);

            if (account != null && loggedInUsers.ContainsValue(account)) {
                Console.WriteLine($"Account balance: {account.Balance}");
            }
            else {
                Console.WriteLine("Invalid account or not logged in!");
            }
        }
    }

    class Account {
        public int AccountNumber { get; }
        public decimal Balance { get; private set; }
        public string Username { get; }
        public string Password { get; }

        public Account(int accountNumber, decimal initialBalance, string username, string password) {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            Username = username;
            Password = password;
        }

        public void Deposit(decimal amount) {
            Balance += amount;
        }

        public void Withdraw(decimal amount) {
            Balance -= amount;
        }
    }
}
