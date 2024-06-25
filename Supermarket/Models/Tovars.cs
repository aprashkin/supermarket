using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Avalonia.Media.Imaging;

namespace Supermarket.Models;

public class Tovars 
{
    public string TovarName { get; set; }
    public double TovarPrice { get; set; }
    public int TovarCount { get; set; } 
    public Bitmap TovarImage { get; set; }
    public string TovarDescription { get; set; }
    
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class TovarList
{
    public static List<Tovars> tovarsList = new List<Tovars>()
    {
        new Tovars
        {
            TovarName = "Гвоздьё", TovarDescription = "Супер крутой гвоздь",TovarPrice = 14, TovarImage = new Bitmap("C:\\Users\\prdb\\RiderProjects\\supermarket\\Supermarket\\Assets\\avalonia-logo.ico"), TovarCount = 5
        },
        new Tovars
        {
            TovarName = "Гвоздь", TovarDescription = "Супер крутой гвоздь поменьше", TovarPrice = 14, TovarImage = new Bitmap("C:\\Users\\prdb\\RiderProjects\\supermarket\\Supermarket\\Assets\\avalonia-logo.ico"), TovarCount = 5
        }
    };
}
