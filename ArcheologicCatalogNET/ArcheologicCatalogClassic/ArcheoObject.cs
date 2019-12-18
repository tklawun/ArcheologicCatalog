﻿using System;
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
        private string typOfBuild;
        private int height;
        private int width;
        private int depth;
        private string typOfCoordinate;
        private string coordinate;
        private string description;
        private string imagelink;
        private string particularities;

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
            { imagelink = "null"; }
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
            { coordinate = "null"; }
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
            { depth = 0; }
            {
                depth = value;
            }
        }

        
    }
}