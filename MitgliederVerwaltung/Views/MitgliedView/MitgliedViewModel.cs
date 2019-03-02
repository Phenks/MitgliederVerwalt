using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    internal class MitgliedViewModel
    {
        public string Email { get; set; }
        public string Geburtsdatum { get; set; }

        public string Name { get; set; }

        private bool Aktiv { get; set; }

        public string Mitgliedstatus
        {
            get { return Aktiv ? "Aktiv" : "Inaktiv"; }
        }

        public MitgliedViewModel(Mitglied mitglied)
        {
            Geburtsdatum = mitglied.Geburtsdatum.ToString("dd-MM-yyyy");
            
            Email = mitglied.Email;
            Aktiv = mitglied.Aktiv;
            Name = mitglied.VollstaendigerName;
        }
    }
}