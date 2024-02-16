using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendendo_class
{
    internal class home
    {
        public home()
        {
        }
        public void vemhome()
        {
            MenuStrip menu = new MenuStrip();

            // Create the "Home" menu item.
            ToolStripMenuItem homeItem = new ToolStripMenuItem("Home");
            menu.Items.Add(homeItem);

            // Create the "Página Principal" submenu item under "Home".
            ToolStripMenuItem pagePrincipalItem = new ToolStripMenuItem("Página Principal");
            homeItem.DropDownItems.Add(pagePrincipalItem);

        }
    }
}
