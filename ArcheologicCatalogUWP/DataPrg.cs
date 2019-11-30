using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Windows.Storage;

namespace ArcheologicCatalogUWP
{
    class DataPrg
    {

        private ArcheoObject[] archeoObjectList;
        public ArcheoObject getObject(string id)
        {


            return null;

        }

        public ArcheoObject SetArcheoObject(string code, string title, string description, int height, int width, string typOfBuild, string TypOfCoordinate, string imagelink)
        {
            ArcheoObject obj = new ArcheoObject
            {
                Code = code,
                Title = title,
                Description = description,
                Height = height,
                Width = width,
                TypOfBuild = typOfBuild,
                TypOfCoordinate = TypOfCoordinate,
                Imagelink = imagelink
        };
           
            return obj;
        }

        public void AddArcheoObjectToList(ArcheoObject obj)
        {
            //todo: check makes list with new entries
            if (archeoObjectList.Length >= 1)
            {
                archeoObjectList[archeoObjectList.Length] = obj;
            }
        }

        public ArcheoObject[] getArcheoObjectListFromDatabase()
        {
            //todo: get all Database Entries as a list
            
            return archeoObjectList;
        }

        public Boolean writeArcheoObjectListIntoDatabase(ArcheoObject archObj)
        {

            return false;
        }

        public async static void InitializeDatabase()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("sqliteArcheologicCatalog.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "sqliteArcheologicCatalog.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS MyTable (Primary_Key INTEGER PRIMARY KEY, " +
                    "Text_Entry NVARCHAR(2048) NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }


    }
}
