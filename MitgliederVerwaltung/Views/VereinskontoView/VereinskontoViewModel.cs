using System.Collections.Generic;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;

namespace MitgliederVerwaltung.Views.VereinskontoView
{
    public class VereinskontoViewModel : ViewModelBasis
    {
        public List<Transaktion> Transaktionen { get; set; }

        public VereinskontoViewModel(Konto konto)
        {
            Transaktionen = konto.Transaktionen;

        }
    }
}