using System.ComponentModel;
using testApp.ViewModels;
using Xamarin.Forms;

namespace testApp.Views
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