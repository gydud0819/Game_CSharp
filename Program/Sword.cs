using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Sword : Item, IEquipable
    {
        public Sword(string _name, int _power, int _dex, int _intel) : base(_name, _power, _dex, _intel)    // 그지같은 base
        {
            Console.WriteLine("[아이템 이름] : " + _name);

            Console.WriteLine("속도 : " + _dex);
            Console.WriteLine("지능 : " + _intel);
            Console.WriteLine("힘 : " + _power);
        }

        public void Equip()
        {
            // 여기 뭐써?? 아이템 정보?
            // 강화할 내용 쓰라고?
            // ???????????
            Power += 3;
            Dex += 1;
            Intel = 2;

            //Console.WriteLine("[아이템 이름] : " + Name);

            Console.WriteLine("장착시 속도 : " + Dex);
            Console.WriteLine("장착시 지능 : " + Intel);
            Console.WriteLine("장착시 힘 : " + Power);

        }
    }
}
