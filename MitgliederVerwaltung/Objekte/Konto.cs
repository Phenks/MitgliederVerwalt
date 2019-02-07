using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Objekte
{
    class Konto
    {
        public Person Inhaber { get; set; }
        public string Kontonummer { get; set; }
        public float Kontostand { get; set; }
        public List<Transaktion> Transaktionen { get; set; }
    }
}
