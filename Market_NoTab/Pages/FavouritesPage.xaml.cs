﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Market_NoTab.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FavouritesPage : ContentPage
	{
        public int Fav_ID { get; set; }
        public FavouritesPage ()
		{
			InitializeComponent ();
		}
	}
}