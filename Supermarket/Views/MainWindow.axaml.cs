using Avalonia.Controls;
using Supermarket.Models;

namespace Supermarket.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        TovarListBox.ItemsSource = TovarList.tovarsList;
    }
}