using System;
using System.Diagnostics;

namespace SingleResponsibility
{
    class Program
    {
        /// <summary>
        /// A class should only have a single responsibility, that is, only 
        /// changes to one part of the software's specification should be able 
        /// to affect the specification of the class.
        /// 
        /// Created a separated Persistence class from the Journal class
        /// to keep single responsibility principle.
        /// </summary>
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today");
            journal.AddEntry("I ate a bug");

            Console.WriteLine(journal);

            var persistence = new Persistence();
            var filename = @"c:\users\public\journal.txt";
            persistence.SaveToFile(journal, filename, true);
            Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
        }
    }
}
