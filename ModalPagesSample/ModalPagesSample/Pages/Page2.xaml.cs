using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace ModalPagesSample
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void OnShowNextButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3());
        }

        private async void OnDismissButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
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
            // バックキーを無効化
            return true;
        }
    }
}
