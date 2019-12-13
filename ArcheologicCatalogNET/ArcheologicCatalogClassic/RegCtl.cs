using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ArcheologicCatalogClassic
{
    class RegCtl
    {
       public void SetPathForPictureFolderIntoRegistry(string PathToPictureFolder)
        {
            string keyname = "Software\\ArcheoCatalog";
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(keyname);
            rk.SetValue("ImageFolder", PathToPictureFolder, RegistryValueKind.String);

        }

        public string GetPathForPictureFolderIntoRegistry()
        {
            string PathToPictureFolder = "Null";
            string keyname = "Software\\ArcheoCatalog";
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(keyname);
            PathToPictureFolder = rk.GetValue("ImageFolder").ToString();
            return PathToPictureFolder;
        }
    }
}
