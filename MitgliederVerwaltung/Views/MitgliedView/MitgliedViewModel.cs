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

        private Mitglied _mitglied;

        public MitgliedViewModel(Mitglied mitglied)
        {

            _mitglied = mitglied;
            Geburtsdatum = mitglied.Geburtsdatum.ToString("dd-MM-yyyy");
            
            Email = mitglied.Email;
            Mitgliedstatus = mitglied.Aktiv ? "Aktiv" : "Inaktiv";
            Name = mitglied.VollstaendigerName;

            Bearbeiten = new DelegateCommand((o => UserBearbeiten()));
        }

        public void UserBearbeiten()
        {
            new MitgliederBearbeitenView(_mitglied).Show();
        }

    }
}