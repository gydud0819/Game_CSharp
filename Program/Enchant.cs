using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Enchant
    {      
        public void Enhanse(IEquipable item)      // 객체를 따로 안불러와도 가능함 
        {
            item.Equip();
            Console.WriteLine();
        }
    }
}
