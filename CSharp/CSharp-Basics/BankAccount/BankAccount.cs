using System;

class BankAccount
{
  private decimal balance = 0;

  // Deposit money into the account
  public void Deposit(decimal amount)
  {
    balance += amount;
  }

  // Retrieve the current balance
  public decimal GetBalance()
  {
    return balance;
  }
}

class Program
{
  static void Main(string[] args)
  {
    // Create two bank account instances
    BankAccount account1 = new BankAccount();
    BankAccount account2 = new BankAccount();

    // Deposit money into each account
    account1.Deposit(100);
    account2.Deposit(200);
    account1.Deposit(200);

    // Display the balances of both accounts
    Console.WriteLine($"Account1 balance: {account1.GetBalance()}");
    Console.WriteLine($"Account2 balance: {account2.GetBalance()}");
  }
}
