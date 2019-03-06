using System;
using System.Collections.Generic;
using System.Linq;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Services;
using MitgliederVerwaltung.Views.MitgliedView;

namespace MitgliederVerwaltung.Views.MitgliederansichtView
{
    public class MitgliederUebersichtViewModel : ViewModelBasis
    {
        private List<MitgliedView.MitgliedView> _mitglieder;
        private string _suchBegriff;

        public DelegateCommand UserHinzufuegen{ get; set; }

        public List<MitgliedView.MitgliedView> Mitglieder
        {
            get { return _mitglieder; }
            set { SetProperty(ref _mitglieder, value); }
        }

        public string SuchBegriff
        {
            get { return _suchBegriff; }
            set { SetProperty(ref _suchBegriff, value); }
        }

        public MitgliederUebersichtViewModel()
        {
            MitgliederAktualisieren();   
            VereinService.Instanz.MitgliederUpdated += MitgliederAktualisieren;

            UserHinzufuegen = new DelegateCommand(o => OnUserHinzufuegenKlick());


        }

        public void MitgliederAktualisieren()
        {
            Mitglieder = VereinService.Instanz.ErhalteMitglieder()
                .Select(mitglied => new MitgliedView.MitgliedView(new MitgliedViewModel(mitglied))).ToList();
        }

        public void OnUserHinzufuegenKlick()
        {
            var mitgliedAnlegen = new MitgliederBearbeitenView();
            mitgliedAnlegen.Show();

        }
        
    }
}