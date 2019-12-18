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
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            details1.Text = "Name: " + App.Fname + " " + App.Lname; //creating output using get and set method calls
            details2.Text = "Weight: " + App.Weight;//creating output using get and set method calls
            details3.Text = "Height: " + App.Height;//creating output using get and set method calls
            bmi.Text = "BMI: " + App.Bmi;//creating output using get and set method calls
        }

        private void BackButton2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1());
        }
    }
}