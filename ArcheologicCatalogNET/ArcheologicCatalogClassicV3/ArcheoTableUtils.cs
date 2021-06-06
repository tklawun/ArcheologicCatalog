using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheologicCatalogClassicV3.Model;
using Microsoft.Azure.Cosmos.Table;

namespace ArcheologicCatalogClassicV3
{
    class ArcheoTableUtils
    {
        public static async Task<ArcheoEntity> InsertOrMergeEntityAsync(CloudTable table, ArcheoEntity entitiy)
        {
            if (entitiy == null)
            {
                throw new ArgumentNullException("ArcheoEntity");
            }

            try
            {
                Microsoft.Azure.Cosmos.Table.TableOperation insertOrMergeOperation = TableOperation.InsertOrMerge(entitiy);
                TableResult result = await table.ExecuteAsync(insertOrMergeOperation);
                ArcheoEntity insertedCustomer = result.Result as ArcheoEntity;
                
                if (result.RequestCharge.HasValue)
                {
                    Console.WriteLine("Request Charge of InsertOrMerge Operation: " + result.RequestCharge);
                }
                return insertedCustomer;
            }
            catch (StorageException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                throw;
            }
        }

        public static async Task<ArcheoEntity> RetrieveEntityUsingPointQueryAsync(CloudTable table, string partitionKey, string rowKey)
        {
            try
            {
                TableOperation retrieveOperation = TableOperation.Retrieve<ArcheoEntity>(partitionKey, rowKey);
                TableResult result = await table.ExecuteAsync(retrieveOperation);
                ArcheoEntity archeoObj = result.Result as ArcheoEntity;
                if (archeoObj != null)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", archeoObj.PartitionKey, archeoObj.RowKey, archeoObj.Description, archeoObj.Code);
                }

                if (result.RequestCharge.HasValue)
                {
                    Console.WriteLine("Request Charge of Retrieve Operation: " + result.RequestCharge);
                }

                return archeoObj;
            }
            catch (StorageException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                throw;
            }
        }

        public static async Task DeleteEntityAsync(CloudTable table, ArcheoEntity deleteEntity)
        {
            try
            {
                if (deleteEntity == null)
                {
                    throw new ArgumentNullException("deleteEntity");
                }

                TableOperation deleteOperation = TableOperation.Delete(deleteEntity);
                TableResult result = await table.ExecuteAsync(deleteOperation);

                if (result.RequestCharge.HasValue)
                {
                    Console.WriteLine("Request Charge of Delete Operation: " + result.RequestCharge);
                }

            }
            catch (StorageException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                throw;
            }
        }
    }
}
 