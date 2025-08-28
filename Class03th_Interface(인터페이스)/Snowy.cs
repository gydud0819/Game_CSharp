using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Snowy : Terrain, ICoverable, ITraversable
    {
        public Snowy() : base(300, 200) { }

        public override void Activate()
        {
            Console.WriteLine("Traverse : " + Traverse());
        }

        public override void Describe()
        {
            Console.WriteLine("snowy filed");
            Console.WriteLine($"width : {width}, height : {height}");
        }

        public void TakeCover()
        {
            Console.WriteLine("설원 엄폐");
        }

        public bool Traverse()
        {
            return true;
        }
    }
}
