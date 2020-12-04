using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class InputExcption : Exception
    {
        public InputExcption(string msg) : base(msg) { }
    }
}
