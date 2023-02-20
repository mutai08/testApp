using System;
using System.Collections.Generic;
using System.ComponentModel;
using testApp.Models;
using testApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}