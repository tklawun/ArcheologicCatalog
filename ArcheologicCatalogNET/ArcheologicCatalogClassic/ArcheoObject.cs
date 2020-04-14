using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassic
{
    public class ArcheoObject
    {
        private string title;
        private string code;
        private int currentNumber;
        private string typOfBuild;
        private int height;
        private int width;
        private int depth;
        private string typOfCoordinate;
        private string coordinate;
        private string description;
        private string imagelink;
        private string particularities;
        private string ShortPath;

        public string GetParticularities()
        {
            return particularities;
        }

        public void SetParticularities(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                particularities = "null";
            }
            { 
                particularities = value;
            }
        }

        public string GetTitle()
        {
             return title;
        }

        public void SetTitle(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                title = "null";
            }
            { 
                title = value;
            }
        }

        public string GetCode()
        {
            return code;
        }
        public string GetShortPath()
        {
            return ShortPath;
        }

        public int GetCurrentNumber()
        {
            return currentNumber;
        }

        public void SetCurrentNumber(int value)
        {
            currentNumber = value;
        }
        public void SetShortPath(string path)
        {
            ShortPath = path;
        }
        public void SetCode(string value)
        {
            if (string.IsNullOrEmpty(value))
            { code = "null"; }
            {
                code = value;
            }
        }

        public string GetTypeOfBuild()
        {
            return typOfBuild;
        }

        public void SetTypOfBuild(string value)
        {
            if (string.IsNullOrEmpty(value))
            { typOfBuild = "null"; }
            {
                typOfBuild = value;
            }
        }

        public int GetHeight()
        {
            return height;
        }

        public void SetHeight(int value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            { height = 0; }
            {
                height = value;
            }
        }

        public int GetWidth()
        {
            return width;
        }

        public void SetWidth(int value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            { width = 0; }
            {
                width = value;
            }
        }

        public string GetTypeOfCoordinate()
        {
            return typOfCoordinate;
        }

        public void SetTypOfCoordinate(string value)
        {
            if (string.IsNullOrEmpty(value))
            { typOfCoordinate = "null"; }
            {
                typOfCoordinate = value;
            }
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string value)
        {
            if (string.IsNullOrEmpty(value))
            { description = "null"; }
            {
                description = value;
            }
        }

        public string GetImagelink()
        {
                return imagelink;
        }

        public void SetImagelink(string value)
        {
            if (string.IsNullOrEmpty(value))
            { 
                imagelink = "null"; 
            }
            else
            {
                imagelink = value;
            }
        }

        public string GetCoordinate()
        {
            return coordinate;
        }

        public void SetCoordinate(string value)
        {
            if (string.IsNullOrEmpty(value))
            { 
                coordinate = "null"; 
            }
            else
            {
                coordinate = value;
            }
        }

        public int GetDepth()
        {
            return depth;
        }

        public void SetDepth(int value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            { 
                depth = 0; 
            }
            else
            {
                depth = value;
            }
        }
    }
}