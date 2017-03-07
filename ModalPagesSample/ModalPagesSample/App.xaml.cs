using Xamarin.Forms;
using Util;

namespace ModalPagesSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TopPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Trace.WriteMethod();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Trace.WriteMethod();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Trace.WriteMethod();
        }
    }
}
