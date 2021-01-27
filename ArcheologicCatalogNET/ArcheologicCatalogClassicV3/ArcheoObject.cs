using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV3
{
    class ArcheoObject
    {
        private string Id;
        private string Code;
        private string Coordinates;
        private string TypOfBuild;
        private string Height;
        private string Width;
        private string Depth;
        private string Description;
        private string SpecialFeatures;
        private string PictureLink;
        private string RockType;

        internal string IdOut { get => Id; set => Id = value; }
        internal string CodeOut { get => Code; set => Code = value; }
        internal string CoordinatesOut { get => Coordinates; set => Coordinates = value; }
        internal string DescriptionOut { get => Description; set => Description = value; }
        internal string HeightOut { get => Height; set => Height = value; }
        internal string WidthOut { get => Width; set => Width = value; }
        internal string DepthOut { get => Depth; set => Depth = value; }
        internal string Particularities { get => Description; set => Description = value; }
        internal string SpecialFeaturesOut { get => SpecialFeatures; set => SpecialFeatures = value; }
        internal string PictureLinkOut { get => PictureLink; set => PictureLink = value; }
        internal string RockTypeOut { get => RockType; set => RockType = value; }
        internal string TypOfBuildOut { get => TypOfBuild; set => TypOfBuild = value; }

        /// <summary>
        /// Gibt die verfügbaren Porperties zurück
        /// </summary>
        /// <returns>verfügbare Properties</returns>
        internal string[] GetObjectProperties()
        {
            String[] ObjectProperties = new string[] { "ID", "Code", "Coordinates", "TypOfBuild", "Height", "Width", "Depth", "Description", "SpecialFeatures", "PictureLink", "RockType" };
            return ObjectProperties;
        }

        internal ArcheoObject GetArcheoObject()
        {
            return this;
        }

        internal string[] GetArcheoObject(bool AsString)
        {
            string[] archeoAsString = new string[] { Id, Code, Coordinates, TypOfBuild, Height, Width, Depth, Description, SpecialFeatures, PictureLink, RockType };
            return archeoAsString;

        }

        internal void SetArcheoObject(string Id, string Code, string Coordinates, string TypOfBuild, string Height, string Width, string Depth, string Description, string SpecialFeatures, string PictureLink, string RockType)
        {
            this.Id = Id;
            this.Code = Code;
            this.Coordinates = Coordinates;
            this.TypOfBuild = TypOfBuild;
            this.Height = Height;
            this.Width = Width;
            this.Depth = Depth;
            this.Description = Description;
            this.SpecialFeatures = SpecialFeatures;
            this.PictureLink = PictureLink;
            this.RockType = RockType;
        }

        internal void SetArcheoObject(Dictionary<string, string> keyValuePairs)
        {
            foreach (KeyValuePair<string, string> property in keyValuePairs)
            {
                if (property.Key.Equals("Id")) { this.Id = property.Value.ToString(); };
                if (property.Key.Equals("Code")) { this.Code = property.Value.ToString(); };
                if (property.Key.Equals("Coordinates")) { this.Coordinates = property.Value.ToString(); };
                if (property.Key.Equals("TypOfBuild")) { this.TypOfBuild = property.Value.ToString(); };
                if (property.Key.Equals("Height")) { this.Height = property.Value.ToString(); };
                if (property.Key.Equals("Width")) { this.Width = property.Value.ToString(); };
                if (property.Key.Equals("Depth")) { this.Depth = property.Value.ToString(); };
                if (property.Key.Equals("Description")) { this.Description = property.Value.ToString(); };
                if (property.Key.Equals("SpecialFeatures")) { this.SpecialFeatures = property.Value.ToString(); };
                if (property.Key.Equals("PictureLink")) { this.PictureLink = property.Value.ToString(); };
                if (property.Key.Equals("RockType")) { this.RockType = property.Value.ToString(); };
            }
        }

        internal Dictionary<string, string> GetArcheoObjectAsDictonary()
        {
            Dictionary<string, string> archeoObject = new Dictionary<string, string>();
            archeoObject.Add("Id", this.Id);
            archeoObject.Add("Code", this.Code);
            archeoObject.Add("Coordinates", this.Coordinates);
            archeoObject.Add("TypOfBuild", this.TypOfBuild);
            archeoObject.Add("Height", this.Height);
            archeoObject.Add("Width", this.Width);
            archeoObject.Add("Depth", this.Depth);
            archeoObject.Add("Description", this.Description);
            archeoObject.Add("SpecialFeatures", this.SpecialFeatures);
            archeoObject.Add("PictureLink", this.PictureLink);
            archeoObject.Add("RockType", this.RockType);
            return archeoObject;

        }
    }
}
