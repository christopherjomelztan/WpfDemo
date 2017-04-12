using System.Windows;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainViewModel = new MainViewModel();
            var mainView = new MainWindow();
            mainView.DataContext = mainViewModel;

            mainViewModel.FirstName = "FirstName";
            mainViewModel.LastName = "LastName";

            mainView.Show();
        }
    }
}
