using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Warrior : Movable
    {
    

        public void Move()
        {
            Console.WriteLine("용병");
            Console.WriteLine("[하는 일] : 공주랑 도망가기");
        }
    }
}
