﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class BrushTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }
        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
