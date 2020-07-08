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
        private ProgramCtl programCtl;

        public RegCtl(ProgramCtl programCtl)
        {
            this.programCtl = programCtl;
        }

        public void SetPathForPictureFolderIntoRegistry(string PathToPictureFolder)
        {
            string keyname = "Software\\ArcheoCatalog";
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(keyname);
            rk.SetValue("ImageFolder", PathToPictureFolder, RegistryValueKind.String);
        }

        public string GetPathForPictureFolderFromRegistry()
        {
            string keyname = "Software\\ArcheoCatalog";
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(keyname);
            string PathToPictureFolder;
            try
            {
                PathToPictureFolder = rk.GetValue("ImageFolder").ToString();
            }
            catch (Exception)
            {
                //Todo: wenn der Key nicht gesetzt ist, war es der erste Start, sollte man da nicht erstmal Config starten?

                //PathToPictureFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                //SetPathForPictureFolderIntoRegistry(PathToPictureFolder);
                PathToPictureFolder = "null";
                
            }

            return PathToPictureFolder;
        }

        public void SetCodePatternIntoRegistry(string CodePattern)
        {
            string keyname = "Software\\ArcheoCatalog";
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(keyname);
            rk.SetValue("CodePattern", CodePattern, RegistryValueKind.String);
        }

        public string GetCodePatternFromRegistry()
        {
            string keyname = "Software\\ArcheoCatalog";
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(keyname);
            string CodePattern;
            try
            {
                CodePattern = rk.GetValue("CodePattern").ToString();
            }
            catch (Exception)
            {
                CodePattern = Properties.Resources.CodePattern;
                SetCodePatternIntoRegistry(CodePattern);
            }

            return CodePattern;
        }

        public Boolean CheckIsRegKeyExists()
        {
            //Todo: prüft auf ersten Start durch Test, ob der Registry Schluessel vorhanden ist. 
            string keyname = "Software\\ArcheoCatalog";
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(keyname);
            if(rk == null)
            {
                return false;
            }
            {
                return true;
            }
        }

    }
}
