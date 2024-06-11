using System.Collections.Generic;
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
}

public class TovarList
{
    public static List<Tovars> tovarsList = new List<Tovars>()
    {
        new Tovars
        {
            TovarName = "Гвоздь", TovarPrice = 14, TovarImage = new Bitmap("C:\\Users\\PROFI\\RiderProjects\\Supermarket\\Supermarket\\Assets\\avalonia-logo.ico"), TovarCount = 5
        },
        new Tovars
        {
            TovarName = "Гвоздь", TovarPrice = 14, TovarImage = new Bitmap("C:\\Users\\PROFI\\RiderProjects\\Supermarket\\Supermarket\\Assets\\avalonia-logo.ico"), TovarCount = 5
        }
    };
}