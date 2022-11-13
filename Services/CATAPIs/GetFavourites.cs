using RestSharp;

namespace Services.CATAPIs
{

    public class GetFavourites
    {
        private string endpoint = "https://api.thecatapi.com/v1/favourites/";

        public RestResponse GetFavs()
        {
            var client = new RestClient(endpoint);
            var request = new RestRequest("",Method.Get);
            request.AddHeader("x-api-key", "live_yytzud7VDISKCkF5ZRozfv78jGDF5MAkFDBD5r4q1l9My23TKXqVKvgFp9lmHCuA");
            RestResponse response = client.Execute(request);

            return response;
        }

    }
}
