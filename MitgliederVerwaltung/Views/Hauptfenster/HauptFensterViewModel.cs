﻿using System.Windows.Input;

namespace MitgliederVerwaltung.Views.Hauptfenster
{
    class HauptFensterViewModel : ViewModelBasis
    {

        private readonly DelegateCommand _changeNameCommand;
        public ICommand ChangeNameCommand => _changeNameCommand;


        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public HauptFensterViewModel()
        //test
        {
            _changeNameCommand = new DelegateCommand(OnChangeName,CanChangeName);
        }

        private bool CanChangeName(object commandParameter)
        {
            return Name != "Drölf";
        }

        private void OnChangeName(object commandParameter)
        {
            Name = "Drölf";
            _changeNameCommand.InvokeCanExecuteChanged();
        }

        
    }
}
