using Spy_Screen_Shot_2.ViewModels;
using Spy_Screen_Shot_2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Spy_Screen_Shot_2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
