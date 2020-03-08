using InterfaceSegregation.Inferfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Photocopier : ICopier, IPrinter
    {
        public void Copy(Document document)
        {
            //implement copy code for photocopier
        }

        public void Print(Document document)
        {
            //implement print code for photocopier
        }
    }
}
