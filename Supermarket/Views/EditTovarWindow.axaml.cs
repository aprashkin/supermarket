using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Supermarket.Models;

namespace Supermarket.Views;

public partial class EditTovarWindow : Window
{
    public string TovarName { get; set; }
    public double TovarPrice { get; set; }
    public int TovarCount { get; set; } 
    public Bitmap TovarImage { get; set; }
    public string TovarDescription { get; set; }
    public Tovars EditedTovar { get; set; }

    public EditTovarWindow(int tovarId)
    {
        InitializeComponent();
        Tovars tovars = TovarList.tovarsList.Single(t => t.TovarId == tovarId);
        EditedTovar = tovars;
        TovarName = EditedTovar.TovarName;
        TovarPrice = EditedTovar.TovarPrice;
        TovarCount = EditedTovar.TovarCount;
        TovarImage = EditedTovar.TovarImage;
        TovarDescription = EditedTovar.TovarDescription;
        Imgar.Source = tovars.TovarImage;
    }
    
    public EditTovarWindow()
    {
        InitializeComponent();
    }
}