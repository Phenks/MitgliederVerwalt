using System;
using System.Collections.Generic;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;
using MitgliederVerwaltung.Views.Mitglied;

namespace MitgliederVerwaltung.Views.Mitgliederansicht
{
    public class MitgliederUebersichtViewModel : ViewModelBasis
    {
        private List<MitgliedView> _mitglieder;
        private string _suchBegriff;

        public List<MitgliedView> Mitglieder
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
            Objekte.Mitglied mitglied1 = new Objekte.Mitglied("Peter", "Oetker", new DateTime(2000, 1, 1),
                new Anschrift("49124", "Hütte", "Steinstraße", "42"), Konstanten.Erwerbstaetigkeiten.Student,
                new Konto(1458.42f),"peter.oetker@gmail.com");

            Mitglieder = new List<MitgliedView>
            {
                new MitgliedView(mitglied1)
            };
        }
    }
}