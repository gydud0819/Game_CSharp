using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Terrain
    {
        protected int width;    // 가로
        protected int height;   // 세로

        public int Width { get { return width; } }
        public int Height { get { return height; } }

        // 생성자에서 초기화가 무슨말이야 
        public Terrain(int _width, int _height)
        {
            width= _width;
            height= _height;
        }

       
        public abstract void Describe();      // 함수에  abstract 붙이면 추상 함수로 바뀐다. 
        public abstract void Activate();

    }
}
