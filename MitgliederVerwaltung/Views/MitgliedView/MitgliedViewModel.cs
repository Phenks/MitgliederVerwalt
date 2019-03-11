using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    public class MitgliedViewModel
    {
        public string Email { get; set; }
        public string Geburtsdatum { get; set; }
        public string Name { get; set; }
        public string Mitgliedstatus { get; set; }
        public DelegateCommand Bearbeiten { get; set; }
        public DelegateCommand Info { get; set; }
        public string Beitrag { get; set; }

        private Mitglied _mitglied;

        public MitgliedViewModel(Mitglied mitglied)
        {

            _mitglied = mitglied;
            Geburtsdatum = mitglied.Geburtsdatum.ToString("dd-MM-yyyy");
            
            Email = mitglied.Email;
            Mitgliedstatus = mitglied.Aktiv ? "Aktiv" : "Inaktiv";
            Name = mitglied.VollstaendigerName;
            Beitrag = $" {mitglied.Monatsbeitrag} €";
            Bearbeiten = new DelegateCommand((o => UserBearbeiten()));
            Info = new DelegateCommand((o => UserAnzeigen()));
        }

        public void UserBearbeiten()
        {
            new MitgliederBearbeitenView(_mitglied).Show();
        }

        public void UserAnzeigen()
        {
            new MitgliedInfoView(_mitglied).Show();
        }

    }
}