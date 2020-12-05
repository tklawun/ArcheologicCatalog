using Microsoft.Office.Interop.Word;

namespace ArcheologicCatalogClassicV3
{
    class Export
    {
        
        public void ExportToWord(ArcheoObject archeoObject, string fullFileName)
        {
            archeoObject = new ArcheoObject();

            object documentTyp = 0;
            object visible = true;
            object fileName = fullFileName;
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
            object textmarke = new object();
            int i = 0;
            foreach (string property in textmarkes)
            {
                textmarke = textmarkes[i];
                oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = archeoObject.GetArcheoObject(true)[i];
                i++;
            }
            

            oWordDoc.Close();
            oWordApp.Quit();
            //oWordDoc.SaveAs2(fileName);

        }


    }
}
