using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;
using MitgliederVerwaltung.Services;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    class MitgliedBearbeitenViewModel : ViewModelBasis
    {
        private string _vorname;
        public string Vorname
        {
            get { return _vorname; }
            set { SetProperty(ref _vorname, value); }
        }



        public DelegateCommand Speichern { get; set; }

        public MitgliedBearbeitenViewModel()
        {
            Speichern = new DelegateCommand(((o) => OnSpeichernKlick() ));
        }

        public void OnSpeichernKlick()
        {
            //var mitglied = new Mitglied(Vorname);
            //MitgliederService.Instanz.FuegeMitgliedHinzu(mitglied);
        }

        public MitgliedBearbeitenViewModel(Mitglied mitglied)
        {
            Vorname = mitglied.Vorname;
        }

    }
}
