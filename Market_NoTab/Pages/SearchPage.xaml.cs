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
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
		}

        private void Start_Search(object sender, EventArgs e)
        {
            string Input = Search_Entry.Text;
            if(Input == null) {
                var All_Sellers = new Get_All_Sellers();
                Application.Current.MainPage.Navigation.PushAsync(new SearchResultsPage(){
                    BindingContext = All_Sellers
                });
            } else {//since we have no proper regexp output for the uri, its just gonna be all for the mean while
                var All_Sellers = new Get_All_Sellers();
                Application.Current.MainPage.Navigation.PushAsync(new SearchResultsPage() {
                    BindingContext = All_Sellers
                });
            }
           
        }
    }
}