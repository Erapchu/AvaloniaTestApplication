using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaTestApplication.ViewModels
{
    public partial class SampleViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _title;
    }
}
