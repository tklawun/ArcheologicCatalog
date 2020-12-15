using Microsoft.Office.Interop.Word;
using System.Collections.Generic;

namespace ArcheologicCatalogClassicV3
{
    class Export
    {

        public void ExportToWord(ArcheoObject archeoObject, string FullDirectory)
        {
            object documentTyp = 0;
            object visible = true;
            object fileName = FullDirectory + archeoObject.CodeOut + ".docx";
            string fullTemplateName = new FilePaths().getTemplatePath();
            object templateName = fullTemplateName;
            object missing = System.Reflection.Missing.Value;
            Application oWordApp = new Application();
            oWordApp.Visible = true;
            Document oWordDoc = oWordApp.Documents.Add(ref templateName, missing, documentTyp, visible);

            oWordDoc.Activate();

            int test = oWordDoc.Bookmarks.Count;
            bool test1 = oWordDoc.Bookmarks.Exists("Code");
            string[] textmarkes = archeoObject.GetObjectProperties();
            string[] archeoObjectAsString = archeoObject.GetArcheoObject(true);
            Dictionary<string, string> archeoObjectAsDict = archeoObject.GetArcheoObjectAsDictonary();
            object textmarke = new object();
            int i = 0;
            foreach (string property in textmarkes)
            {
                textmarke = property;
                bool archeoObjectParam = archeoObjectAsDict.TryGetValue(property, out string value);
                if (archeoObjectParam)
                {
                    oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = value;
                }
                i++;
            }

            //Einfügen Bild
            Range aRange = oWordDoc.Range(Start: oWordDoc.Paragraphs[12].Range.Start, oWordDoc.Paragraphs[13].Range.End);
            oWordDoc.InlineShapes.AddPicture(archeoObject.PictureLinkOut, false, true, aRange); 

            oWordDoc.SaveAs2(fileName);
            oWordDoc.Close();
            oWordApp.Quit();
        }


    }
}
