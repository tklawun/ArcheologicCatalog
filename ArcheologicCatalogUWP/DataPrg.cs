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
        public ArcheoObject GetObject(string code)
        {

            //Todo: This is a Moke ;) : Create new ArcheoObject and get it.
            ArcheoObject archObj = new ArcheoObject
            {
                Code = "test01",
                Title = "test01",
                Description = "this is a Test of Archeo Dataset",
                Height = 120,
                Width = 80,
                Imagelink = "D:/TestOfArcheoCatalog/Pictures/test01.jpg",
                TypOfCoordinate = "GPS",
                Coordinate = "12,12,12,12"
            };
            return archObj;

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
           string[] tableColumnsname = { "code", "title", "description", "height", "width", "typOfBuild", "TypeOfCoordinate", "Coordinate", "imageLink" };
            await ApplicationData.Current.LocalFolder.CreateFileAsync("sqliteArcheologicCatalog.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "sqliteArcheologicCatalog.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS MyTable (Primary_Key INTEGER PRIMARY KEY, " +
                    "Text_Entry NVARCHAR(2048) NULL)";
                String tableCommandArcheoObjectEntry = "CREATE TABLE IF NOT ÊXISTS ArcheoObjectTable " + 
                    "(Primary_Key INTEGER PRIMARY KEY, " +
                    tableColumnsname[0] + " NVARCHAR(2048) NULL " + tableColumnsname[1] + " NVARCHAR(2048) NULL " + 
                    tableColumnsname[2] + " NVARCHAR(8192) NULL " + tableColumnsname[3] + " INTEGER NULL " +
                    tableColumnsname[4] + " INTEGER NULL " + tableColumnsname[5] + " NVARCHAR(2048) NULL " + 
                    tableColumnsname[6] + " NVARCHAR(2048) NULL" + tableColumnsname[7] + " NVARCHAR(2048) NULL" +
                    tableColumnsname[8] + " NVARCHAR(2048) NULL" + ")";
                    
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteCommand createTable01 = new SqliteCommand(tableCommandArcheoObjectEntry);

                createTable.ExecuteReader();
                createTable01.ExecuteReader();
            }
        }


    }
}
