using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Objekte
{
    public class Anschrift
    {
        public string Postleitzahl { get; set; }
        public string Ort { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }

        public Anschrift(string postleitzahl, string ort, string strasse, string hausnummer)
        {
            Postleitzahl = postleitzahl;
            Ort = ort;
            Strasse = strasse;
            Hausnummer = hausnummer;
        }
    }
}
