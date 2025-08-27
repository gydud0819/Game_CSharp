namespace Class02th_Collection_콜렉션_
{
    internal class Collection
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
            //Dictionary<string , int> dictionary = new Dictionary<string , int>();
            //
            //int money = 0;
            //
            //dictionary.Add("Bomb", 500);
            //dictionary.Add("TNT", 1000);
            //
            //foreach (var elem in dictionary)
            //{
            //    Console.WriteLine($"Key : {elem.Key}");
            //    Console.WriteLine($"Value : {elem.Value}");
            //}
            //
            //string key = "TNT2.0";
            //
            //if(dictionary.TryGetValue(key, out money))    // bool 타입이넹
            //{
            //    // 잇으면 가져오고 없으면 ㅖ?
            //    money = dictionary[key];
            //}
            //else
            //{
            //    dictionary.Add(key, 1500);
            //}
            //Console.WriteLine($"money : {money}");

            #endregion

            #region Stack
            //Stack<int> stack = new Stack<int>();
            //
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);
            //
            //while (stack.Count > 0) 
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            #endregion

            #region Queue
            //Queue<int> q = new Queue<int>();
            //q.Enqueue(10);
            //q.Enqueue(20);
            //q.Enqueue(30);
            //q.Enqueue(40);
            //q.Enqueue(50);
            //
            //while (q.Count > 0)
            //{
            //    Console.WriteLine(q.Dequeue());     // Dequeue로 뽑아낸다(?)
            //}
            #endregion

            #region Linked List (양방향 연결 리스트)
            //LinkedList<int> linkedlist = new LinkedList<int>();
            //
            //linkedlist.AddFirst(10);
            //linkedlist.AddFirst(5);
            //linkedlist.AddFirst(2);
            //
            //linkedlist.AddLast(23);
            //
            //foreach (var elem in linkedlist)
            //{
            //    Console.WriteLine(elem);
            //}

            #endregion

            #endregion
        }
    }
}
