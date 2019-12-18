using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodSherpa2
{
    public partial class MainPage : ContentPage
    {
        public String firstName = " ";
        public String lastName = " "; 

        public MainPage()
        {
            InitializeComponent();
        }

        private void ContinueButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1()); //method of navigation from one page to another
        }

      

        private void LName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            App.Lname = lName.Text; //using get and set to make inputs global in the project

        }

        private void FName_TextChanged(object sender, TextChangedEventArgs e)
        {
            App.Fname = fName.Text; //using get and set to make inputs global in the project
        }
    }
}
