using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Table;

namespace ArcheologicCatalogClassicV3.Model
{
    class ArcheoEntity : TableEntity
    {
        internal string Id { get; set; }
        internal string Code { get; set; }
        internal string Coordinates { get; set; }
        internal string Description { get; set; }
        internal string Height { get; set; }
        internal string Width { get; set; }
        internal string Depth { get; set; }
        internal string Particularities { get; set; }
        internal string SpecialFeatures { get; set; }
        internal string PictureLink { get; set; }
        internal string RockType { get; set; }
        internal string TypOfBuild { get; set; }
        
        public ArcheoEntity(string Id, string Code)
        {
            PartitionKey = Id;
            RowKey = Code;
        }


    }
}
