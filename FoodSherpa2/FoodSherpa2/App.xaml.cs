using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FoodSherpa2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        public static string Fname { get; set; }

        public static string Lname { get; set; }

        public static double Weight { get; set; }

        public static double Height { get; set; }

        public static double Bmi { get; set; }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
