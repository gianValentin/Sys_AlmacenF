using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sys_AlmacenF
{
    class Responzive
    {
        public static void responzivePoint(Control padre, Control hijo)
        {
            int x = 0;
            x = (padre.Width / 2) - (hijo.Width / 2);

            hijo.Location = new System.Drawing.Point(x, hijo.Location.Y);
        }

        public static void responziveSize(Control padre,Control hijo)
        {
            hijo.Width = padre.Width - 100;
        }
    }
}
