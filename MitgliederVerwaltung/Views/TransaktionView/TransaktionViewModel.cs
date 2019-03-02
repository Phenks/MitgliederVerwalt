using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitgliederVerwaltung.Objekte;


namespace MitgliederVerwaltung.Views.TransaktionView
{
    class TransaktionViewModel
    {
        public string Sender { get; set; }
        public string Verwendungszweck { get; set; }
        public string Betrag { get; set; }


        public TransaktionViewModel(Transaktion transaktion)
        {
            Sender = transaktion.Sender.Inhaber.VollstaendigerName;
            Verwendungszweck = transaktion.Verwendungszweck;
        }
    }
}
