using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Tools
{
    class EraserTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser icon");
        }
        public void MouseUp()
        {
            Console.WriteLine("Eraser erased an item.");
        }
    }
}
