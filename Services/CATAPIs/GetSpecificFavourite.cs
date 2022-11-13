using RestSharp;

namespace Services.CATAPIs
{

    public class GetSpecificFavourite
    {
        private string endpoint = "https://api.thecatapi.com/v1/favourites/";

        public RestResponse GetASpecificFavourite(string favourite_id)
        {
            var client = new RestClient(endpoint);
            var request = new RestRequest(favourite_id, Method.Get);
            request.AddHeader("x-api-key", "live_yytzud7VDISKCkF5ZRozfv78jGDF5MAkFDBD5r4q1l9My23TKXqVKvgFp9lmHCuA");
            RestResponse response = client.Execute(request);
            //var content = response.Content.ToString();

            return response;
        }
    }
}
