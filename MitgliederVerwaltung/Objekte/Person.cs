using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Objekte
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public Anschrift Anschrift { get; set; }

        public Person(string vorname, string nachname, DateTime geburtsdatum, Anschrift anschrift)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Anschrift = anschrift;
        }
    }
}
