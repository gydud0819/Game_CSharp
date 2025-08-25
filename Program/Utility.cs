using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Utility
    {
        private int data;


  
        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
          
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);

        }

        public int Absolute(in int value)
        {
            // 절대값 : 음수값도 양수로 출력되게 
            return value < 0 ? -value : value;

            
        }
    }
}
