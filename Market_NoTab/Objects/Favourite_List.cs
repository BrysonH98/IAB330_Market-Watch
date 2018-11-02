
using System;
using System.Collections.Generic;
using System.Text;

namespace Market_NoTab.Objects
{
    public class Favourite_List
    {
        public List<Favourite_Seller> Fav_List { get; set; }
    }
    public class Favourite_Seller
    {
        public int sellerID { get; set; }
        public string businessName { get; set; }
        public string email { get; set; }
        public string selPassword { get; set; }
        public int phone { get; set; }
        public string location { get; set; }
    }
}
