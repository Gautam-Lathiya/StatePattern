﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection icon");
        }
        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
}
