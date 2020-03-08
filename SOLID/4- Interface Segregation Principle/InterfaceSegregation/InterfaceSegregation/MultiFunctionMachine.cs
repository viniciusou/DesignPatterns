using InterfaceSegregation.Inferfaces;
using System;

namespace InterfaceSegregation
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private readonly ICopier _copier;
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;

        public MultiFunctionMachine(ICopier copier, IPrinter printer, IScanner scanner)
        {
            _copier = copier ?? throw new ArgumentNullException(paramName: nameof(copier));
            _printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
            _scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
        }

        //using decorator pattern below

        public void Copy(Document document)
        {
            _copier.Copy(document);
        }

        public void Print(Document document)
        {
            _printer.Print(document);
        }

        public void Scan(Document document)
        {
            _scanner.Scan(document);
        }
    }
}
