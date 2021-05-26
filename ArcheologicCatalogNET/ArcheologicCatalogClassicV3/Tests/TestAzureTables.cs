using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheologicCatalogClassicV3.Model;
using Microsoft.Azure.Cosmos.Table;

namespace ArcheologicCatalogClassicV3.Tests
{
    class TestAzureTables
    {
       public async Task RunSamples()
            {
                Console.WriteLine("Azure Cosmos DB Table - Basic Samples\n");
                Console.WriteLine();

                string tableName = "demo" + Guid.NewGuid().ToString().Substring(0, 5);

                // Create or reference an existing table
                CloudTable table = await Common.CreateTableAsync(tableName);

                try
                {
                    // Demonstrate basic CRUD functionality 
                    await BasicDataOperationsAsync(table);
                }
                finally
                {
                    // Delete the table
                    await table.DeleteIfExistsAsync();
                }
            }

            private static async Task BasicDataOperationsAsync(CloudTable table)
            {
                // Create an instance of a customer entity. See the Model\CustomerEntity.cs for a description of the entity.
                ArcheoEntity archeoObj = new ArcheoEntity("Harp", "Walter")
                {
                    Particularities = "Walter@contoso.com",
                    Description = "425-555-0101"
                };

                // Demonstrate how to insert the entity
                Console.WriteLine("Insert an Entity.");
                archeoObj = await ArcheoTableUtils.InsertOrMergeEntityAsync(table, archeoObj);

                // Demonstrate how to Update the entity by changing the phone number
                Console.WriteLine("Update an existing Entity using the InsertOrMerge Upsert Operation.");
                archeoObj.Description = "425-555-0105";
                await ArcheoTableUtils.InsertOrMergeEntityAsync(table, archeoObj);
                Console.WriteLine();

                // Demonstrate how to Read the updated entity using a point query 
                Console.WriteLine("Reading the updated Entity.");
                archeoObj = await ArcheoTableUtils.RetrieveEntityUsingPointQueryAsync(table, "Harp", "Walter");
                Console.WriteLine();

                // Demonstrate how to Delete an entity
                //Console.WriteLine("Delete the entity. ");
                //await SamplesUtils.DeleteEntityAsync(table, customer);
                //Console.WriteLine();
            }
        }
    }

