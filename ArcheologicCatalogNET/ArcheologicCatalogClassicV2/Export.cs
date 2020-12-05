using Microsoft.Office.Interop.Word;

namespace ArcheologicCatalogClassicV2
{
    class Export
    {
        
        public void ExportToWord(ArcheoObject archeoObject, string fullFileName)
        {
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
            bool test1 =  oWordDoc.Bookmarks.Exists("Title");
            string[] textmarkes = { "Title", "Code", "Heigth", "Width", "Depth", "Width",  };
            object textmarke = textmarkes[0].ToString();
            oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = archeoObject.GetTitle();
            textmarke = textmarkes[1].ToString();
            oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = archeoObject.GetCode();
            textmarke = textmarkes[2].ToString();
            oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = archeoObject.GetCode();
            textmarke = textmarkes[3].ToString();
            oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = archeoObject.GetHeight().ToString();
            textmarke = textmarkes[4].ToString();
            oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = archeoObject.GetWidth().ToString();
            textmarke = textmarkes[5].ToString();
            oWordDoc.Bookmarks.get_Item(ref textmarke).Range.Text = archeoObject.GetDepth().ToString();



            oWordDoc.Close();
            oWordApp.Quit();
            //oWordDoc.SaveAs2(fileName);

        }


    }
}
