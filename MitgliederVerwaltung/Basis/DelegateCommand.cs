using System;
using System.Windows.Input;

namespace MitgliederVerwaltung.Basis
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Func<object, bool> _canExecuteAction;

        public DelegateCommand(Action<object> executeAction, Func<object, bool> canExecuteAction )
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;


        }
        public DelegateCommand(Action<object> executeAction )
        {
            _executeAction = executeAction;
            _canExecuteAction = (o) => true;
        }

        public void Execute(object parameter) => _executeAction(parameter);

        public bool CanExecute(object parameter) => _canExecuteAction?.Invoke(parameter) ?? true;

        public event EventHandler CanExecuteChanged;

        public void InvokeCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
