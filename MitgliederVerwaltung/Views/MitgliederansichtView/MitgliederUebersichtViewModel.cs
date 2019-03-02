using System;
using System.Collections.Generic;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Views.MitgliederansichtView
{
    public class MitgliederUebersichtViewModel : ViewModelBasis
    {
        private List<Mitglied> _mitglieder;
        private string _suchBegriff;

        public List<Mitglied> Mitglieder
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
           
           
        }
    }
}