using Avalonia.Controls;
using Supermarket.Models;
using Supermarket.ViewModels;

namespace Supermarket.Views
{
    public partial class EditTovarWindow : Window
    {
        private Tovars _selectedTovar;

        public EditTovarWindow(Tovars selectedTovar)
        {
            InitializeComponent();
            _selectedTovar = selectedTovar;

            // Привязка контекста данных или инициализация с выбранным товаром
            DataContext = new EditTovarViewModel(_selectedTovar);
        }
    }
}

