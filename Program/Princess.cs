using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Princess : Damageable
    {
      
        public void Damage(float damage)
        {
            Console.WriteLine("공주");
            Console.WriteLine("[하는 일] 공격당하기 : " + damage);
        }
    }
}
