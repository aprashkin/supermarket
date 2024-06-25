using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Supermarket.Models;
using Supermarket.ViewModels;

namespace Supermarket.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
        TovarListBox.ItemsSource = TovarList.tovarsList;
    }

    private void add_tovar(object? sender, RoutedEventArgs e)
    {
        AddProduct _addProduct = new AddProduct(new MainWindowViewModel());
        _addProduct.Show();
        Close();
    }

    private void delete_tovar(object sender, RoutedEventArgs e)
    {
        var selectedItem = TovarListBox.SelectedItem as Tovars;

        if (selectedItem != null)
        {
            // Удаление товара из коллекции
            TovarList.tovarsList.Remove(selectedItem);
            TovarListBox.ItemsSource = null;
            TovarListBox.ItemsSource = TovarList.tovarsList;
        }
    }
}