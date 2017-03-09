using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace ModalPagesSample
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void OnDismissButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void OnShowNavigationRootButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NavigationRootPage()));
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
