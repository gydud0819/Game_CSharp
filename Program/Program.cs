using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 컬렉션 (Collection)

            #region List
            //List<int> list = new List<int>();
            //
            //list.Capacity = 10;
            //
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add(40);
            //list.Add(50);
            //
            //list.Remove(40);
            //list.Insert(3, 75);
            //
            //foreach (int elem in list)      // : 이게 없넹 
            //{
            //    Console.WriteLine(elem);
            //}
            #endregion

            #region Dictionary
            // Hash Table 구조
            Dictionary<string , int> dictionary = new Dictionary<string , int>();

            int money = 0;

            dictionary.Add("Bomb", 500);
            dictionary.Add("TNT", 1000);

            foreach (var elem in dictionary)
            {
                Console.WriteLine($"Key : {elem.Key}");
                Console.WriteLine($"Value : {elem.Value}");
            }

            string key = "TNT2.0";

            if(dictionary.TryGetValue(key, out money))    // bool 타입이넹
            {
                // 잇으면 가져오고 없으면 ㅖ?
                money = dictionary[key];
            }
            else
            {
                dictionary.Add(key, 1500);
            }
            Console.WriteLine($"money : {money}");
         
            #endregion

            #endregion

        }
    }
}
