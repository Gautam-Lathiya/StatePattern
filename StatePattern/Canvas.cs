using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Canvas
    {
        private Tool currentTool;

        public Tool CurrentTool
        {
            get { return currentTool; }
            set { currentTool = value; }
        }

        public void MouseDown()
        {
            currentTool.MouseDown();
        }

        public void MouseUp()
        {
            currentTool.MouseUp();
        }
    }
}
