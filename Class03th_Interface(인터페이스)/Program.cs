using Program;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Class03th_Interface_인터페이스_
{
    internal class Interface
    {
        static void Main(string[] args)
        {
            #region 추상 클래스 
            // 직접 생성할 순 없지만 다른 클래스가 상속받아 구체적인 기능을 만들 수 있도록 설계되어 있는 클래스
            // 어유 큰일낫네 기억이 가물가물한데;;

            Terrain terrain;
            terrain = new Forest();
            terrain.Describe();
            terrain.Activate();
            terrain = new Desert();
            terrain.Describe();
            terrain.Activate();
            terrain = new Snowy();
            terrain.Describe();
            terrain.Activate();
            #endregion
        }
    }
}
