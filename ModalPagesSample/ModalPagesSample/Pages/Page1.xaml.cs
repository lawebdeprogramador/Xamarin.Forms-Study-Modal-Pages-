using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace ModalPagesSample
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void OnShowNextButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page2());
        }

        private async void OnDismissButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Trace.WriteMethod();
            Trace.WriteModalStack(this);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Trace.WriteMethod();
            Trace.WriteModalStack(this);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
