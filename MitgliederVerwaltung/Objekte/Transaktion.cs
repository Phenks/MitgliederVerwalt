using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Objekte
{
    class Transaktion
    {
        public Konto Empfaenger { get; set; }
        public Konto Sender { get; set; }
        public float Betrag { get; set; }
        public DateTime Zeitpunkt { get; set; }
    }
}
