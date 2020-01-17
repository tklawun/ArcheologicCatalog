using System;
using System.Collections.Generic;
using System.IO;
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
            string PathToPictureFolder = null;
            string keyname = "Software\\ArcheoCatalog";
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(keyname);
            try
            {
                PathToPictureFolder = rk.GetValue("ImageFolder").ToString();
            }
            catch (Exception)
            {
                PathToPictureFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                SetPathForPictureFolderIntoRegistry(PathToPictureFolder);
                //Todo: wenn der Key nicht gesetzt ist, war es der erste Start, sollte man da nicht erstmal Config starten?
            }
            
            return PathToPictureFolder;
        }

    }
}
