using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Grammar
{
    public struct Vector2
    {
        public int x;
        public int y;

        // 이게 생성자
        public Vector2(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

    }
    internal class Utility
    {
        private int data;

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);

        }

        public int Absolute(in int value)
        {
            // 절대값 : 음수값도 양수로 출력되게 
            return value < 0 ? -value : value;

        }



        // 문법 그지같네 진짜 
        public void Magnitude(Vector2 vector2, out float length)
        {

            length = (float)Math.Sqrt(vector2.x * vector2.x + vector2.y * vector2.y);
            // 그 생성자를 대체 어디에..

            // |v| = Math.sqrt(x2+y2) 제곱이엇나..? 벡터길이 구하기,,
        }

    }

}
