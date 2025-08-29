using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Trader : ITradable
    {
     
    
        public void Trade()
        {
            Console.WriteLine("상인");
            Console.WriteLine("[하는 일] 물건팔기");
        }
    }
}
