using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogUWP
{
    class DataPrg
    {

        private ArcheoObject[] archeoObjectList;
        public ArcheoObject getObject(string id)
        {


            return null;

        }

        public ArcheoObject setArcheoObject(string code, string title, string description, int height, int width )
        {
            ArcheoObject obj = new ArcheoObject();
            obj.Code = code;
            obj.Title = title;
            obj.Description = description;
            obj.Height = height;

            
            return obj;
        }


        public ArcheoObject[] getArcheoObjectListFromDatabase()
        {


            return archeoObjectList;
        }

        public Boolean writeArcheoObjectListIntoDatabase()
        {



            return false;
        }

    }
}
