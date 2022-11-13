using RestSharp;

namespace Services.CATAPIs
{
    public class DeleteAFavourite
    {
        private string endpoint = "https://api.thecatapi.com/v1/favourites/";

        public RestResponse DeleteFavourite(string imageId)
        {
            //build the uri
            var client = new RestClient(endpoint);

            var request = new RestRequest(imageId, Method.Delete);
            request.AddHeader("x-api-key", "live_yytzud7VDISKCkF5ZRozfv78jGDF5MAkFDBD5r4q1l9My23TKXqVKvgFp9lmHCuA");

            //Get Call
            RestResponse response = client.Execute(request);

            //read the response

            return response;
        }
    }
}
