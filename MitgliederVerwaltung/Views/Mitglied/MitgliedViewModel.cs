namespace MitgliederVerwaltung.Views.Mitglied
{
    internal class MitgliedViewModel
    {
        public string Email { get; set; }
        public string Geburtsdatum { get; set; }
        private string Nachname { get; }

        public string Name
        {
            get { return $"{Vorname} {Nachname}"; }
        }

        private string Vorname { get; }
        private bool Aktiv { get; set; }

        public string Mitgliedstatus
        {
            get { return Aktiv ? "Aktiv" : "Inaktiv"; }
        }

        public MitgliedViewModel(Objekte.Mitglied mitglied)
        {
            Geburtsdatum = mitglied.Geburtsdatum.ToString("dd-MM-yyyy");
            Vorname = mitglied.Vorname;
            Nachname = mitglied.Nachname;
            Email = mitglied.Email;
            Aktiv = mitglied.Aktiv;
        }
    }
}