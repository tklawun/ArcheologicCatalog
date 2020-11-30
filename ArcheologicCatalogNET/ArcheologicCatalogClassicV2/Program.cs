using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheologicCatalogClassicV2
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //get the Entries of archeo-Objects
            ArcheoObjectListForm archeoObjectListForm = new ArcheoObjectListForm();
            
            Application.Run(archeoObjectListForm);
        }

    }
}
