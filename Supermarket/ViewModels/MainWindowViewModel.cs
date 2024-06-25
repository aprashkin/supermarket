using System.Collections.ObjectModel;
using Supermarket.Models;

namespace Supermarket.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Tovars> TovarsList { get; set; } = new ObservableCollection<Tovars>();

    public MainWindowViewModel()
    {
        TovarsList = new ObservableCollection<Tovars>();
    }
}