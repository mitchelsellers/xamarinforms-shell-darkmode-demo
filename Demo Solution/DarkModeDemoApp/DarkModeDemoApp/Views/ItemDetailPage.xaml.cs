using System.ComponentModel;
using Xamarin.Forms;
using DarkModeDemoApp.ViewModels;

namespace DarkModeDemoApp.Views
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