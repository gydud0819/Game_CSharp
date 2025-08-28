using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Enchant
    {      
        public void Enforse(Item item)      // 객체를 따로 안불러와도 가능함 
        {
            if (item.Name == "임프의 신발")
            {
                item.Dex = 3;
            }
            else if (item.Name == "낡아빠진 엘림스의 가면")
            {
                item.Power = 1;
                item.Intel = 2;
            }
            else if(item.Name == "라라의 목걸이")
            {
                item.Power = 2;
            }
        }
    }
}
