using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Market_NoTab.Objects;
using RestSharp;
using RestSharp.Deserializers;


namespace Market_NoTab.Functions
{
    public class Get_Favourites
    {
        public List<Favourite_Seller> Favourite_List { get; set; }

        public Get_Favourites(int User_ID){
            
            string string_ID = User_ID.ToString();
            string uri = "/api/Seller/cusID=" + string_ID + "/fav=true";

            var client = new RestClient("http://marketwatchapi.azurewebsites.net");
            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute(request);

            RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();


            if (response.StatusCode == HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                List<Favourite_Seller> json_response = deserial.Deserialize<List<Favourite_Seller>>(response);
                Favourite_List = json_response;
            }
        }

        public List<Favourite_Seller> Return_Fav_List() {
            return this.Favourite_List;
        }
    }
}
