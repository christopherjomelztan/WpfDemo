using System;
using System.Windows.Input;

namespace WpfDemo
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;
        private readonly Predicate<object> _canExecute;
        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action action)
            : this(action, null)
        { }

        public DelegateCommand(Action action, Predicate<object> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _action?.Invoke();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
