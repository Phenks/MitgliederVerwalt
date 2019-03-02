using System.Collections.Generic;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Views.Vereinskonto
{
    public class VereinskontoViewModel : ViewModelBasis
    {
        public List<TransaktionView> Transaktionen { get; set; }

        public VereinskontoViewModel(Konto konto)
        {
            Transaktionen = konto.Transaktionen;

        }
    }
}