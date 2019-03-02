using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitgliederVerwaltung.Objekte
{
    public class Transaktion
    {
        public Konto Empfaenger { get; set; }
        public Konto Sender { get; set; }
        public float Betrag { get; set; }
        public DateTime Zeitpunkt { get; set; }
        public string Verwendungszweck { get; set; }

        public Transaktion(Konto empfaenger, Konto sender, float betrag, DateTime zeitpunkt, string verwendungszweck)
        {
            Empfaenger = empfaenger;
            Sender = sender;
            Betrag = betrag;
            Zeitpunkt = zeitpunkt;
            Verwendungszweck = verwendungszweck;
        }
    }
}
