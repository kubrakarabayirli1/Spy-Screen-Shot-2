using Spy_Screen_Shot_2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Spy_Screen_Shot_2.Views
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