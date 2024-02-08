using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface IBaseArray : IPrinter
    {
        public void FillRandom();
        public void FillKeyboard();
        public void Middle();

    }

    interface IPrinter
    {
        public void Print();
    }

}
