using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitgliederVerwaltung.Basis;
using DateTime = System.DateTime;

namespace MitgliederVerwaltung.Views.Simulation
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
            var datum = DateTime.Now;
            Datum = datum.ToString("D");
        }

    }
}
