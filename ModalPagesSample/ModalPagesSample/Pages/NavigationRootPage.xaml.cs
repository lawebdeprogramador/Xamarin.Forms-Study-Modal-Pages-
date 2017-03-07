using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace ModalPagesSample
{
    public partial class NavigationRootPage : ContentPage
    {
        public NavigationRootPage()
        {
            InitializeComponent();
        }

        private async void OnDismissButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void OnPopToRootButton(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(true);
        }

        private async void OnNextButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PushPage1());
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
            // バックキーを無効化
            return true;
        }
    }
}
