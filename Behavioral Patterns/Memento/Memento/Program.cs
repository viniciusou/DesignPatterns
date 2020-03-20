using System;

namespace Memento
{
    /// <summary>
    /// The memento pattern is a software design pattern that provides the ability to 
    /// restore an object to its previous state (undo via rollback).
    /// 
    /// 
    /// Memento is a token/handle representing the system state. Lets us rollback to
    /// the state when the token was generated. May or may not directly expose state
    /// information.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(100);
            var memento1 = bankAccount.Deposit(50); //150
            var memento2 = bankAccount.Deposit(25); //175
            Console.WriteLine(bankAccount);

            bankAccount.Undo();
            Console.WriteLine($"Undo 1: {bankAccount}");
            bankAccount.Undo();
            Console.WriteLine($"Undo 2: {bankAccount}");
            bankAccount.Redo();
            Console.WriteLine($"Redo: {bankAccount}");
        }
    }
}
