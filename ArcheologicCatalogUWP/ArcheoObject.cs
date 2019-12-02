using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogUWP
{
    class ArcheoObject
    {
        private string title;
        private string code;
        private string typOfBuild;
        private int height;
        private int width;
        private string typOfCoordinate;
        private string coordinate;
        private string description;
        private string imagelink;

        public string Title { get => title; set => title = value; }
        public string Code { get => code; set => code = value; }
        public string TypOfBuild { get => typOfBuild; set => typOfBuild = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public string TypOfCoordinate { get => typOfCoordinate; set => typOfCoordinate = value; }
        public string Description { get => description; set => description = value; }
        public string Imagelink { get => imagelink; set => imagelink = value; }
        public string Coordinate { get => coordinate; set => coordinate = value; }
    }
}
