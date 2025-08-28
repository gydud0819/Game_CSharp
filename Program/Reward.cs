using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Reward
    {
        private float exp;
        private int money;
        private int specialMoney;

        public Reward(float _exp, int _money, int _specialMoney)
        {
            exp = _exp;
            money = _money;
            specialMoney = _specialMoney;
        }

        // 요기 함수를 만들어야하나? 
        public void GetReward()
        {
            Console.WriteLine("[보상]");
            Console.WriteLine("경험치 : " + exp);
            Console.WriteLine("돈 : " + money);
            Console.WriteLine("전용재화 : " + specialMoney);
            
        }
    }
}
