using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Azure.Documents;

namespace ArcheologicCatalogClassicV3
{
    class Common
    {
        public static CloudStorageAccount CreateStorageAccountFromConnectionString(string storageConnectionsString)
        {
            CloudStorageAccount storageAccount;
            try
            {
                storageAccount = CloudStorageAccount.Parse(storageConnectionsString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid storage account information provided, Please confirm the information");
                Console.Read();
                throw;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid storage account information provided, Please confirm the information.");
                Console.Read();
                throw;
            }
            return storageAccount;
        }
        public static async Task<CloudTable> CreateTableAsync(string tableName)
        {
            string storageConnectionString = AppSettings.LoadAppSettings().StorageConnectionString;

            CloudStorageAccount storageAccount = CreateStorageAccountFromConnectionString(storageConnectionString);

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient(new TableClientConfiguration());

            CloudTable table = tableClient.GetTableReference(tableName);
            if (await table.CreateIfNotExistsAsync())
            { Console.WriteLine("Table {0} created", tableName);}
            else { Console.WriteLine("Table {0} already exists", tableName); }
            return table;
        }
    }
}
