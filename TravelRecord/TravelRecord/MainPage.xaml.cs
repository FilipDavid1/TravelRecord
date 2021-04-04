using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecord
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void LoginButton_OnClicked(object sender, EventArgs e)
        {
          bool isEmailEmpty = string.IsNullOrEmpty(EmailEntry.Text);
          bool isPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

          if (isEmailEmpty || isPasswordEmpty)
          {
              
          }
          else
          {
              Navigation.PushAsync(new HomePage());
          }
        }
    }
}
