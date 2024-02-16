using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
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
