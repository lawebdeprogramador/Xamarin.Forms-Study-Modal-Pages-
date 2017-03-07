using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace ModalPagesSample
{
    public partial class PushPage3 : ContentPage
    {
        public PushPage3()
        {
            InitializeComponent();
        }

        private async void OnPrevButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }

        private async void OnPopToRootButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(true);
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
