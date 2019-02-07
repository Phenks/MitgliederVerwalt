using System.Windows.Input;

namespace MitgliederVerwaltung.Views.Hauptfenster
{
    class HauptFensterViewModel : ViewModelBasis
    {

        private readonly DelegateCommand _changeNameCommand;
        public ICommand ChangeNameCommand
        {
            get
            {
                return _changeNameCommand;
            }
        }

        private string _name;
        public string Name
        {
            get { return _name ; }
            set { SetProperty(ref _name, value); }
        }

        public HauptFensterViewModel()
        {
            _changeNameCommand = new DelegateCommand( OnChangeName,CanChangeName);
        }

        private bool CanChangeName(object commandParameter)
        {
            return true;
        }

        private void OnChangeName(object commandParameter)
        {
            Name = "Drölf";
            _changeNameCommand.InvokeCanExecuteChanged();
        }

        
    }
}
