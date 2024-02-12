namespace Flat_App;

public class ViewModel : ObservableObject
{
    private object _currentView;

    public ViewModel()
    {
        HomeVM = new HomeViewModel();
        DiscoveryVM = new DiscoveryViewModel();
        _currentView = HomeVM;

        HomeViewCommand = new RelayCommand(() => { CurrentView = HomeVM; });
        DiscoveryViewCommand = new RelayCommand(() => { CurrentView = DiscoveryVM; });
    }

    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand DiscoveryViewCommand { get; set; }

    public HomeViewModel HomeVM { get; set; }
    public DiscoveryViewModel DiscoveryVM { get; set; }

    public object CurrentView
    {
        get => _currentView;
        set
        {
            _currentView = value;
            OnPropertyChanged(null);
        }
    }
}