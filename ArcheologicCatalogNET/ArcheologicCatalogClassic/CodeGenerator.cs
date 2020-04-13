using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheologicCatalogClassic
{
    class CodeGenerator
    {
        private string codeMuster;
        private ProgramCtl prgCtl; 
        public CodeGenerator(ProgramCtl programCtl)
        {
            prgCtl = programCtl;
            codeMuster = prgCtl.GetCodePattern();

        }
        public string newCode()
        {
            int laufendeNummer = 1;
            string newCode = codeMuster + laufendeNummer.ToString();
            //TODO: Auslesen des letzten XML Elememts

            return newCode;
        }

      private int getLastCodeNumber()
        {
            int lastCodenumber;
            lastCodenumber = 0; 
            return lastCodenumber + 1;

        }
        

    }
}
