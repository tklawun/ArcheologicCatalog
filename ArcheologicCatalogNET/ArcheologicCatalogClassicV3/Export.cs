using Microsoft.Office.Interop.Word;

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
            bool test1 =  oWordDoc.Bookmarks.Exists("Code");
            string[] textmarkes = archeoObject.GetObjectProperties();
            string[] archeoObjectAsString = archeoObject.GetArcheoObject(true);
            object textmarke = new object();
            int i = 0;
            foreach (string property in textmarkes)
            {
                textmarke = textmarkes[i];
                oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = archeoObjectAsString[i];
                i++;
            }

            oWordDoc.SaveAs2(fileName);
            oWordDoc.Close();
            oWordApp.Quit();
        }


    }
}
