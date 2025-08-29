using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Program
{
    internal class Shoes : Item, IEquipable
    {
        public Shoes(string _name, int _power, int _dex, int _intel) : base(_name, _power, _dex, _intel)
        {
            Console.WriteLine("[아이템 이름] : " + _name);

            Console.WriteLine("속도 : " + _dex);
            Console.WriteLine("지능 : " + _intel);
            Console.WriteLine("힘 : " + _power);
        }

        public void Equip()
        {
           
            // 내용 쓰면되는건가 
            // 뭐써?요?
            Dex += 2;
            Power = 0;
            Intel += 1;

            //Console.WriteLine("[아이템 이름] : " + Name);

            Console.WriteLine("장착시 속도 : " + Dex);
            Console.WriteLine("장착시 지능 : " + Intel);
            Console.WriteLine("장착시 힘 : " + Power);
        }
    }
}
