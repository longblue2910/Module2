using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicLib.Class1 pc = new PublicLib.Class1();
            pc.Sum(1, 2);
            InternalLib.Class1 ic = new InternalLib.Class1();
            ic.Sum(1, 2);
        }
    }
}
