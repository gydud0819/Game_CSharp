using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Forest : Terrain, ITraversable
    {
        // 각 클래스 생성자에서 초기화여..? 
        public Forest() : base(100, 400) { }    // 왜 base 써요..? 초기화도 적응이 안되네 c#이랑 너무 낯가린다 이니셜라이저 초기화가 이게 맞나..? 

        public override void Activate()
        {
            Console.WriteLine("Traverse : " + Traverse());
        }

        public override void Describe()
        {
    
            Console.WriteLine("a forest full of trees");
            Console.WriteLine($"width : {width}, height : {height}");
          
            //throw new NotImplementedException();    // 예외처리 
        }

        public bool Traverse()
        {
           return false;
        }
    }
}
