using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CATAPIs
{

    public class FavouritesSaveImage
    {
        private string endpoint = "https://api.thecatapi.com/v1/favourites";

        public RestResponse SaveImageAsFavourite(string imageid)
        {
            //var endpoint = "https://api.thecatapi.com/v1/favourites";
            var client = new RestClient(endpoint);

            var request = new RestRequest("", Method.Post);

            //set the request body values
            SaveFavouriteParameterObject body = new SaveFavouriteParameterObject();
            body.image_id = imageid;
            body.sub_id = "your-user-dara123122";

            //add headers required
            request.AddHeader("x-api-key", "live_yytzud7VDISKCkF5ZRozfv78jGDF5MAkFDBD5r4q1l9My23TKXqVKvgFp9lmHCuA");
            request.AddHeader("content-type", "application/json");

            //add parameters
            request.AddParameter(@"application/json", body, ParameterType.RequestBody);

            RestResponse response = client.Execute(request);

            return response;
        }
    }
}
