namespace ArcheologicCatalogClassicV3
{
    internal class ArcheoConfigParameter
    {
        private string[] parameters;
        private string parameterType;

        internal ArcheoConfigParameter(string parameterType)
        {
            //Lade die XML Daten falls existent
            ArcheoConfigXmlData archeoConfigXmlData = new ArcheoConfigXmlData();
            this.parameters = archeoConfigXmlData.GetListFromXMLDoc(parameterType);
        }
        internal string[] Parameters { get => Parameters; set => Parameters = value; }
        internal string ParameterType { get => parameterType; set => parameterType = value; }

        internal void AddNewParameter(string parameter)
        {
            //Todo: suche ob Eintrag existent, wenn ja, überschreiben, ansonsten neu. 
        }

        internal void RemoveParmeter(string parameter)
        {
            //Prüfen ob Eintrag existent, wenn ja, löschen, ansonsten nichts machen
        }

        internal void SaveRockTypeInXML()
        {
            ArcheoConfigXmlData archeoConfigXmlData = new ArcheoConfigXmlData();
            archeoConfigXmlData.GenerateXMLDocumentFromList(Parameters, parameterType);
        }
    }
}