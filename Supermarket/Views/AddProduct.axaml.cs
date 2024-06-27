using Avalonia;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Supermarket.Models;
using Supermarket.ViewModels;

namespace Supermarket.Views;

public partial class AddProduct : Window
{
    private MainWindowViewModel mainWindow;
    
    public AddProduct(MainWindowViewModel mainWindow)
    {
        InitializeComponent();
        this.mainWindow = mainWindow;
    }


    private async void addiing(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(TovarNameBox.Text) || (string.IsNullOrEmpty(TovarDescriptionBox.Text)||(string.IsNullOrEmpty(TovarCountBox.Text))||(string.IsNullOrEmpty(TovarPriceBox.Text)))            )
        {
            Error.Text = "Заполните все поля!";
            await Task.Delay(3000);
            Error.Text = string.Empty;
            return;
        }

        if (!int.TryParse(TovarCountBox.Text, out int count))
        {
            Error.Text = "Введите коррректное количество!";
            await Task.Delay(3000);
            Error.Text = string.Empty;
            return;
        }

        if (!double.TryParse(TovarPriceBox.Text, out double price))
        {
            Error.Text = "Введите корректную цену!";
            await Task.Delay(3000);
            Error.Text = string.Empty;
            return;
        }

        var newTovar = new Tovars
        {
            TovarName = TovarNameBox.Text,
            TovarDescription = TovarDescriptionBox.Text,
            TovarCount = count,
            TovarPrice = price,
            TovarImage = new Bitmap("C:\\Users\\kristy\\RiderProjects\\supermarket\\Supermarket\\Assets\\avalonia-logo.ico")
        };
        
        TovarList.tovarsList.Add(newTovar);

        TovarCountBox.Text = string.Empty;
        TovarDescriptionBox.Text = string.Empty;
        TovarNameBox.Text = string.Empty;
        TovarPriceBox.Text = string.Empty;
        MainWindow ainWindow = new MainWindow();
        ainWindow.Show();
        this.Close();
    }
}