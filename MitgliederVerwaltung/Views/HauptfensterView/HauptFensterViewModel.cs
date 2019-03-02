using System.Windows.Input;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Views.MitgliedView;

namespace MitgliederVerwaltung.Views.HauptfensterView
{
    class HauptFensterViewModel : ViewModelBasis
    {

        public DelegateCommand UserHinzufuegen { get; set; }

        private string _name;
        public string Name
        {
            get { return _name ; }
            set { SetProperty(ref _name, value); }
        }

        public HauptFensterViewModel()
        {
            UserHinzufuegen = new DelegateCommand( (o => OnUserHinzufuegenKlick()) );
        }

        private void OnUserHinzufuegenKlick()
        {
            new MitgliederBearbeitenView();
        }

     

        
    }
}
