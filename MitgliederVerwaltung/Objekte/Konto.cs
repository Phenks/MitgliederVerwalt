using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Objekte
{
    public class Konto
    {
        public Person Inhaber { get; set; }
        public string Kontonummer { get; set; }
        public float Kontostand { get; set; }
        
        public List<Transaktion> Transaktionen { get; set; }

        public Konto(float kontostand)
        {
            Random random = new Random();
            Kontonummer = random.Next(1000000000,Int32.MaxValue).ToString();
            Kontostand = kontostand;
            Transaktionen = new List<Transaktion>();
        }
    }
}
