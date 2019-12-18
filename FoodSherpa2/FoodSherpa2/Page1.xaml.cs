using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodSherpa2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        double bmi = 0.0;
        public Page1()
        {
            InitializeComponent();
            names.Text = "Welcome " + App.Fname + " " + App.Lname;//using input from the initial page to output the users name
        }

    

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        private void UnitKg_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                App.Weight = double.Parse(unitKg.Text);//converting text inputs to double for use in calculation
            }
            catch(System.FormatException)
            {
                App.Weight = 0;
            }
        }

        private void UnitM_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                App.Height = double.Parse(unitM.Text);//converting text inputs to double for use in calculation
            }
            catch (System.FormatException)
            {
                App.Height = 0;
            }
        }

        private void CalcButton_Clicked(object sender, EventArgs e)
        {
            double result = App.Weight / (App.Height * App.Height);//calculation for the bmi
            App.Bmi = Math.Round(result, 2);
  
            Navigation.PushModalAsync(new Page2()); //navigation to next page
        }
    }
}