using MitgliederVerwaltung.Basis;
using DateTime = System.DateTime;

namespace MitgliederVerwaltung.Views.SimulationView
{
    class SimulationViewModel : ViewModelBasis
    {
        private string _datum;
        public string Datum
        {
            get { return _datum;}
            set { SetProperty(ref _datum, value); }
        }

        public SimulationViewModel()
        {
            var datum =new DateTime(2019,03,2);
            Datum = datum.ToString("D");
        }

    }
}
