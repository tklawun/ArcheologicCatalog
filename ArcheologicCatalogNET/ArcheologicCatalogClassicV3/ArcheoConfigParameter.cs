using System;
using System.Collections.Generic;

namespace ArcheologicCatalogClassicV3
{
    internal class ArcheoConfigParameter
    {
        private List <string> parameters;
        private string parameterType;

        
        internal ArcheoConfigParameter(string parameterType)
        {
            //Lade die XML Daten falls existent
            ArcheoConfigXmlData archeoConfigXmlData = new ArcheoConfigXmlData();
            this.parameterType = parameterType;
            this.parameters = archeoConfigXmlData.GetListFromXMLDoc(parameterType);
        }
        internal List<string> Parameters { get => parameters; set => parameters = value; }
        internal string ParameterType { get => parameterType; set => parameterType = value; }

        internal void AddNewParameter(string parameter)
        {
            
            this.parameters.Add(parameter);
        }

        internal void RemoveParmeter(string parameter)
        {
            //Prüfen ob Eintrag existent, wenn ja, löschen, ansonsten nichts machen
        }

        internal void SaveParameterInXML()
        {
            ArcheoConfigXmlData archeoConfigXmlData = new ArcheoConfigXmlData();
            archeoConfigXmlData.GenerateXMLDocumentFromList(Parameters, parameterType);
        }
    }
}