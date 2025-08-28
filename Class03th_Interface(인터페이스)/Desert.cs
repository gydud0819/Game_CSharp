using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Desert : Terrain, ICoverable, ITraversable
    {
        public Desert() : base(500, 500) { }

        public override void Activate()
        {
            Console.WriteLine("Traverse : " + Traverse());
        }


        public override void Describe()
        {
            // 이제 머해요..? 
            Console.WriteLine("dry sand desert");
            Console.WriteLine($"width : {width}, height : {height}");
        }

        public bool Traverse()
        {
            return true;
        }

        void ICoverable.TakeCover()
        {
            Console.WriteLine("사막 엄폐");     // 이게 마자요? 
        }
    }
}
