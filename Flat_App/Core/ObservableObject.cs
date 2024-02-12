using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flat_App;

public class ObservableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string Name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
    }
}