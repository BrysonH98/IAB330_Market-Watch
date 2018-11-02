using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Market_NoTab.Objects;
using RestSharp;
using RestSharp.Deserializers;

namespace Market_NoTab.Functions
{
    public class Get_All_Sellers
    {
        public List<Favourite_Seller> Seller_List { get; set; }

        public Get_All_Sellers()
        {
            string uri = "/api/Seller";

            var client = new RestClient("http://marketwatchapi.azurewebsites.net");
            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute(request);

            RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();


            if (response.StatusCode == HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                List<Favourite_Seller> json_response = deserial.Deserialize<List<Favourite_Seller>>(response);
                Seller_List = json_response;
            }
        }
    }
}
