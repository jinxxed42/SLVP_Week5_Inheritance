using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_Inheritance
{
    internal class SubClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("This message is from the subclass!");
        }
    }
}
