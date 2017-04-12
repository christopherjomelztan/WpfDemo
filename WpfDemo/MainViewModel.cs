using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfDemo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        

        public event PropertyChangedEventHandler PropertyChanged;
       
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }





        public ICommand SayHelloCommand
        {
            get; set;
        }



        public DelegateCommand ClearCommand
        {
            get; set;
        }

        public MainViewModel()
        {
            SayHelloCommand = new DelegateCommand(SayHello);
            ClearCommand = new DelegateCommand(Clear, CanClear);
        }


        private string _FirstName;
        private string _LastName;
        public string FirstName { get { return _FirstName; } set
            { _FirstName = value;
                OnPropertyChanged("FirstName");
                ClearCommand.RaiseCanExecuteChanged();
            } }

        public string LastName {get { return _LastName; } set { _LastName = value; OnPropertyChanged("LastName");
                ClearCommand.RaiseCanExecuteChanged();
            } }


        

        private void SayHello()
        {
            MessageBox.Show("Hello " + FirstName + " " + LastName);
        }
        private void Clear()
        {
            FirstName = "";
            LastName = "";

        }

        private bool CanClear(object parameter)
        {
            return !string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(LastName);
        }
    }
}
