using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bai_nop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Debug.WriteLine("Started...");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("Sleeped...");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("Resumed...");
        }
    }
}
