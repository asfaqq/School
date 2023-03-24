using System.ComponentModel;
using Xamarin.Forms;
using проект.ViewModels;

namespace проект.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}