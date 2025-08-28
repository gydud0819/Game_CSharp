using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Item
    {
        private string name;
        private int power;  // 힘 
        private int dex;    // 민첩
        private int intel;  // 지능 

        public string Name { get { return name; } }

        public int Power { get { return power; } set { power = value; } }
        public int Dex { get { return dex; } set {dex = value; } }
        public int Intel { get { return intel; } set { intel = value; } }

        public Item(string _name, int _power, int _dex, int _intel)
        {
            name = _name;
            power = _power;
            dex = _dex;
            intel = _intel;
        }


    }
}
