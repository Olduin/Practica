using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class ContextDefault : Context
    {
        public override Context Display()
        {
            Console.WriteLine(GetType());
            if (Console.ReadKey().Key == ConsoleKey.Escape) return null;

            return this;
        }
    }
}
