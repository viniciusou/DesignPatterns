using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// The command pattern is a behavioral design pattern in which an object is used to 
    /// encapsulate all information needed to perform an action or trigger an event at a 
    /// later time. This information includes the method name, the object that owns the 
    /// method and values for the method parameters.
    /// 
    /// An object which represents an instruction to perform a particular action. In this
    /// case BankAccountCommand contains all the information necessary for the action to 
    /// be taken.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();

            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(bankAccount, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(bankAccount, BankAccountCommand.Action.Withdraw, 50)
            };

            Console.WriteLine(bankAccount);

            foreach(var command in commands)
            {
                command.Call();
            }

            Console.WriteLine(bankAccount);
        }
    }
}
