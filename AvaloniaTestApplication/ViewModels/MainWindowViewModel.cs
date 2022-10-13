using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AvaloniaTestApplication.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public ObservableCollection<SampleViewModel> Samples { get; } = new ObservableCollection<SampleViewModel>();

        public MainWindowViewModel()
        {
            Samples.Add(new SampleViewModel() { Title = "1" });
            Samples.Add(new SampleViewModel() { Title = "2" });
            Samples.Add(new SampleViewModel() { Title = "3" });
            Samples.Add(new SampleViewModel() { Title = "4" });
            Samples.Add(new SampleViewModel() { Title = "5" });
        }
    }
}
