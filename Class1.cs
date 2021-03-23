using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        int i;

        int j;

        public int Counter
        {
            get => i;
            set => i = j;
        }
       

        
        public static void Print() => System.Console.WriteLine("Lol");

    }
}
