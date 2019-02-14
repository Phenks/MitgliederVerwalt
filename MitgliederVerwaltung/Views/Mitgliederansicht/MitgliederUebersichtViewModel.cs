using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitgliederVerwaltung.Basis;

namespace MitgliederVerwaltung.Views.Mitgliederansicht
{
    class MitgliederUebersichtViewModel : ViewModelBasis
    {
        private string _suchBegriff;
        public string SuchBegriff
        {
            get { return _suchBegriff; }
            set { SetProperty(ref _suchBegriff, value); }
        }

    }
}
