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
	public partial class NavPage : ContentPage
	{
        public int User_ID { get; set; }
		public NavPage ()
		{
			InitializeComponent ();
		}

        private void To_Feed(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new FeedPage());
        }
        private void To_Fav(object sender, EventArgs e)
        {
            var Favourite_Result = new Get_Favourites(User_ID);
            Application.Current.MainPage.Navigation.PushAsync(new FavouritesPage() {
                BindingContext = Favourite_Result,
                Fav_ID = User_ID
            });

        }
        private void To_Search(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }
        private void To_Settings(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Settings());
        }
    }
}