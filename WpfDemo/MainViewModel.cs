using System.Windows;
using WpfDemo.Class;

namespace WpfDemo
{
    public class MainViewModel : BindableBase
    {
        private Person _person = new Person();
        public string FirstName
        {
            get { return _person.FirstName; }
            set {
                _person.FirstName = value;
                OnPropertyChanged(nameof(_person.FirstName));
                ClearCommand.RaiseCanExecuteChanged();
                SayHelloCommand.RaiseCanExecuteChanged();
            }
        }
        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                _person.LastName = value;
                OnPropertyChanged(nameof(_person.LastName));
                ClearCommand.RaiseCanExecuteChanged();
                SayHelloCommand.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand SayHelloCommand
        {
            get; set;
        }

        public DelegateCommand ClearCommand
        {
            get; set;
        }

        public MainViewModel()
        {
            SayHelloCommand = new DelegateCommand(SayHello, CommandsEnabled);
            ClearCommand = new DelegateCommand(Clear, CommandsEnabled);
            FirstName = "Natch";
            LastName = "Dev";
        }

        private void SayHello()
        {
            MessageBox.Show("Hello " + FirstName + " " + LastName);
        }
        private void Clear()
        {
            FirstName = "";
            LastName = "";

        }

        private bool CommandsEnabled(object parameter)
        {
            return !string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(LastName);
        }
    }
}
