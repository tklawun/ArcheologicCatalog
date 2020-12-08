using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassicV3
{
    class ArcheoObject
    {
        private string Code;
        private string Coordinates;
        private string Height;
        private string Width;
        private string Depth;
        private string Description;
        private string Designation;
        private string SpecialFeatures;
        private string Picturelink;
        private string RockType;

        public string CodeOut { get => Code; set => Code = value; }
        public string CoordinatesOut { get => Coordinates; set => Coordinates = value; }
        public string HeightOut { get => Height; set => Height = value; }
        public string WidthOut { get => Width; set => Width = value; }
        public string DepthOut { get => Depth; set => Depth = value; }
        public string Particularities { get => Description; set => Description = value; }
        public string DesignationOut { get => Designation; set => Designation = value; }
        public string SpecialFeaturesOut { get => SpecialFeatures; set => SpecialFeatures = value; }
        public string PicturelinkOut { get => Picturelink; set => Picturelink = value; }
        public string RockTypeOut { get => RockType; set => RockType = value; }

        /// <summary>
        /// Gibt die verfügbaren Porperties zurück
        /// </summary>
        /// <returns>verfügbare Properties</returns>
        public string[] GetObjectProperties()
        {
            String[] ObjectProperties = new string[] { "Code", "Coordinates", "Height", "Width", "Depth", "Description", "Designation", "SpecialFeatures", "PicturelinkIntern", "RockType" };
            return ObjectProperties;
        }
        
        public ArcheoObject GetArcheoObject()
        {
            return this;
        }

        public string[] GetArcheoObject(bool AsString)
        {
            string[] archeoAsString = new string[] { Code, Coordinates, Height, Width, Depth, Description, Designation, SpecialFeatures, Picturelink, RockType };
            return archeoAsString;
            
        }

        public void SetArcheoObject(string Code, string Coordinates, string Height, string Width, string Depth, string Description,string Designation, string SpecialFeatures, string Picturelink, string RockType)
        {
            this.Code = Code;
            this.Coordinates = Coordinates;
            this.Height = Height;
            this.Width = Width;
            this.Depth = Depth;
            this.Description = Description;
            this.Designation = Designation;
            this.SpecialFeatures = SpecialFeatures;
            this.Picturelink = Picturelink;
            this.RockType = RockType;
        }

        public void SetArcheoObject(Dictionary<string, string> keyValuePairs)
        {
            foreach (KeyValuePair<string, string> property in keyValuePairs)
            {
                if (property.Key.Equals("Code")) { this.Code = property.Value.ToString(); };
                if (property.Key.Equals("Coordinates")) { this.Coordinates = property.Value.ToString(); };
                if (property.Key.Equals("Height")) { this.Height = property.Value.ToString(); };
                if (property.Key.Equals("Width")) { this.Width = property.Value.ToString(); };
                if (property.Key.Equals("Depth")) { this.Depth = property.Value.ToString(); };
                if (property.Key.Equals("Description")) { this.Description = property.Value.ToString(); };
                if (property.Key.Equals("Designation")) { this.Designation = property.Value.ToString(); };
                if (property.Key.Equals("SpecialFeatures")) { this.SpecialFeatures = property.Value.ToString(); };
                if (property.Key.Equals("PictureLink")) { this.Picturelink = property.Value.ToString(); };
                if (property.Key.Equals("RockType")) { this.RockType = property.Value.ToString(); };
            }
        }

        public Dictionary<string, string> GetArcheoObjectAsDictonary() {
            Dictionary<string, string> archeoObject = new Dictionary<string, string>();
            archeoObject.Add("Code", this.Code);
            archeoObject.Add("Coordinates", this.Coordinates);
            archeoObject.Add("Height", this.Height);
            archeoObject.Add("Width", this.Width);
            archeoObject.Add("Depth", this.Depth);
            archeoObject.Add("Description", this.Description);
            archeoObject.Add("Designation", this.Designation);
            archeoObject.Add("SpecialFeatures", this.SpecialFeatures);
            archeoObject.Add("PictureLink", this.Picturelink);
            archeoObject.Add("RockType", this.RockType);
            return archeoObject;

        }
    }
}
