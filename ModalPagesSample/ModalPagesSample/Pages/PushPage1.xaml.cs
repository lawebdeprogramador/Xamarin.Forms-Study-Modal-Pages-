using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace ModalPagesSample
{
    public partial class PushPage1 : ContentPage
    {
        public PushPage1()
        {
            InitializeComponent();
        }

        private async void OnNextButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PushPage2(), true);
        }

        private async void OnPrevButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Trace.WriteMethod();
            Trace.WriteNavigationStack(this);
            Trace.WriteModalStack(this);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Trace.WriteMethod();
            Trace.WriteNavigationStack(this);
            Trace.WriteModalStack(this);
        }
    }
}
