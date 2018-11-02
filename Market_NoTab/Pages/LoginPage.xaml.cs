using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Market_NoTab.Functions;

namespace Market_NoTab.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private void To_Nav(object sender, EventArgs e)
        {
            if( Email_Entry.Text ==null || Password_Entry.Text == null)  {
                DisplayAlert("Empty Values", "Please Fill in all the the entries", "Return");
            }else{
                var Login_Result = new Get_Login(Email_Entry.Text, Password_Entry.Text);
                if (Login_Result.Validated)
                {
                    Application.Current.MainPage.Navigation.PushAsync(new NavPage() {
                        BindingContext = Login_Result,
                        User_ID = Login_Result.User_Result.customerID
                    });
           
                } else {
                    DisplayAlert("Incorrect Credentials", "The email and/or the password you have entered are incorrect", "Return");
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }
}