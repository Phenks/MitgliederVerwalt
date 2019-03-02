using MitgliederVerwaltung.Objekte;


namespace MitgliederVerwaltung.Views.TransaktionView
{
    class TransaktionViewModel
    {
        public string Sender { get; set; }
        public string Verwendungszweck { get; set; }
        public string Betrag { get; set; }
        public string Timestamp { get; set; }

        public TransaktionViewModel(Transaktion transaktion)
        {
            Sender = transaktion.Sender.Inhaber.VollstaendigerName;
            Verwendungszweck = transaktion.Verwendungszweck;
            Betrag = transaktion.Betrag.ToString();
            Timestamp = transaktion.Zeitpunkt.ToString("dd-MM-yy HH:mm");
        }
    }
}
