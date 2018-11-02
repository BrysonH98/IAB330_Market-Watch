using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Market_NoTab.Objects;
using RestSharp;
using RestSharp.Deserializers;

namespace Market_NoTab.Functions
{
    class Get_Login
    {
        public User User_Result { get; set; }
        public string Input_Email { get; set; }
        public string Input_Password { get; set; }
        public bool Validated { get; set; }

        public Get_Login(string inEmail, string inPass)
        {
            Input_Email = inEmail;
            Input_Password = inPass;
            Validated = false;

            string uri = "/api/Customer/email='" +
                inEmail + "'/cusPassword='" + inPass + "'";

            var client = new RestClient("http://marketwatchapi.azurewebsites.net");
            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Validated = true;
                string rawResponse = response.Content;
                User_Result = new JsonDeserializer().Deserialize<User>(response);
            }
            


        }
    }
}
