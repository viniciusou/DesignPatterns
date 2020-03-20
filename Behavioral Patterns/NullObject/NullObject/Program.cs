using NullObject.Logs;
using System;

namespace NullObject
{
    /// <summary>
    /// A null object is an object with no referenced value or with defined neutral ("null") 
    /// behavior. The null object design pattern describes the uses of such objects and their 
    /// behavior (or lack thereof).
    /// 
    /// The null object is a no-op object that conforms to the required interface, satisfying 
    /// a dependency requirement of some other object.
    /// In this case, when there is a deposit in the bank account the ConsoleLog log warns 
    /// while the NullLog does nothing. You do not need conditionals to check for null 
    /// objects in code and the code does not throw argument null exceptions.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLog = new ConsoleLog();
            var bankAccount1 = new BankAccount(consoleLog);
            bankAccount1.Deposit(100);

            var nullLog = new NullLog();
            var bankAccount2 = new BankAccount(nullLog);
            bankAccount2.Deposit(150);
        }
    }
}
