using AvaloniaTestApplication.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AvaloniaTestApplication.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _greeting = "Welcome to Avalonia!";

        public ObservableCollection<SampleViewModel> Samples { get; } = new ObservableCollection<SampleViewModel>();

        public MainWindowViewModel()
        {
            Samples.Add(new SampleViewModel() { Title = "1" });
            Samples.Add(new SampleViewModel() { Title = "2" });
            Samples.Add(new SampleViewModel() { Title = "3" });
            Samples.Add(new SampleViewModel() { Title = "4" });
            Samples.Add(new SampleViewModel() { Title = "5" });
        }

        [RelayCommand]
        private void ClickMe()
        {
            var window = new MainWindow();
            window.Show();
        }
    }
}
