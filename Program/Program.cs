using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SOLID 원칙 (설계 원칙)

            #region 단일 책임 원칙 (Single Response Principle)
            // 클래스의 구성 단위가 하나의 책임만 가질 수 있도록 설계해야 하는 원칙

            //Quest quest = new Quest("진짜 내 왕자님은 누구?", "아서, 멀린, 랜슬롯 3명의 꽃기사에게 초콜릿 5개씩 주기", new Reward(1000,500,3));       // 정신나간 퀘스트 1 초콜릿 드랍률 미친거
            //
            //Quest quest1 = new Quest("호랑이 굴에 들어가도 정신만 차리면 살.. 수 있나?", "어흥이에게 떡 100개 갖다주기", new Reward(5000, 2000, 5));     // 정신나간 퀘스트 2 (달리면서 떡 나올 확률 0.03%) 미친게임 tq
            //
            //Quest quest2 = new Quest("마도로스 조의 소원", "2m 30cm 이상 물고기 3마리 낚기", new Reward(1000, 1000, 5));                               // 정신나간 퀘스트 3 (2m도 낚기 힘듦 이딴게 힐링이라니)
            //
            //List<Quest> quests = new List<Quest>();
            //
            //quests.Add(quest);
            //quests.Add(quest1);
            //quests.Add(quest2);
            //
            //for (int i = 0; i < quests.Count; i++)
            //{
            //    quests[i].Print();
            //    quests[i].Clear();
            //    Console.WriteLine("\n");
            //}


            #endregion

            #region 개방 폐쇠 원칙 (Open/Closed Principle)
            // 소프트웨어의 구성 요소는 확장에는 열려 있어야 하고, 변경에는 닫혀 있어야 한다.
            // 버트란드 마이어(Bertrand Meyer) 

            //Enchant enchant = new Enchant();
            //enchant.Enhanse(new Shoes("순수의 맨발?", 0, 2, 1));
            //enchant.Enhanse(new Sword("엑스걸리버", 3, 1, 2));


            #endregion

            #region 인터페이스 분리 원칙 (Interface Sergregation Principle)
            // 클래스가 자신이 사용하지 않는 함수에 의존하지 않도록 설게되어야하는 원칙

            Trader trader = new Trader();
            trader.Trade();

            Princess princess = new Princess();
            princess.Damage(5.0f);

            Warrior warrior = new Warrior();
            warrior.Move();
            

            //NPC trader = new Trader("상인", "물건팔기");
            //NPC princess = new Princess("공주", "공격받기");
            //NPC warrior = new Warrior("용병", "공주랑 도망가기");
            
            #endregion
            #endregion


        }
    }
}
