using System;
using System.Data.SqlTypes;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Services;

namespace MitgliederVerwaltung.Views.SimulationView
{
    internal class SimulationViewModel : ViewModelBasis
    {
        private string _momentanesDatum;

        public string MomentanesDatum
        {
            get { return _momentanesDatum; }
            set { SetProperty(ref _momentanesDatum, value); }
        }

        private DateTime _datum;

        public DelegateCommand MonatWeiter { get; set; }

        public DelegateCommand TagWeiter { get; set; }
        public DelegateCommand WocheWeiter { get; set; }


        public SimulationViewModel()
        {
            TagWeiter = new DelegateCommand(o => OnTagWeiter());
            WocheWeiter = new DelegateCommand(o => OnWocheWeiter());
            MonatWeiter = new DelegateCommand(o => OnMonatWeiter());
            _datum = SimulationsService.Instanz.MomentanesDatum;
            AktualisiereMomentanesDatumString();
        }

        private void DatumAendern(DateTime neuesDatum)
        {
            int verstricheneTage = (int)(neuesDatum -_datum ).TotalDays ;
            _datum = SimulationsService.Instanz.SimuliereTage(verstricheneTage);
            AktualisiereMomentanesDatumString();
        }

        private void AktualisiereMomentanesDatumString()
        {
            MomentanesDatum = _datum.ToString("D");
        }

        public void OnTagWeiter()
        {
            DatumAendern(_datum.AddDays(1));
        }

        public void OnWocheWeiter()
        {
            DatumAendern(_datum.AddDays(7));
        }

        public void OnMonatWeiter()
        {
            DatumAendern(_datum.AddMonths(1));
        }
    }
}