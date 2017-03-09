using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace ModalPagesSample
{
    public partial class TopPage : ContentPage
    {
        public TopPage()
        {
            InitializeComponent();
        }

        private async void OnShowNextButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
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

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
