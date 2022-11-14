using Newtonsoft.Json;
using Services.CATAPIs;

namespace APITestsCatAPI.CatAPI
{
    public class CatAPI_Tests
    {

        //get all favourites
        //do some assertions on response
        [Test]
        [Category("CatAPITests")]
        public void GetFavouritesTest()
        {
            GetFavourites catAPI = new GetFavourites();

            //response
            var response = catAPI.GetFavs();
            var responseContent = response.Content.ToString();

            //convert the whole string response into an list which will make it easier to perform assertions on
            var myobjList = JsonConvert.DeserializeObject<List<Favourites>>(responseContent);

            //assertion on the status
            Assert.That(response.StatusCode.ToString(), Is.EqualTo("OK"));
            //assertion on the list content
            Assert.That(myobjList[0].image_id, Is.EqualTo("9ccXTANkb"));
        }


        //set imageid variable with one of the following ids in order to get a successful test, otherwise will be bad request as duplicate
        //aqo,atg,b1j,bah,bd5,c1h,c1k,c6s,c9f,cbu,ce5,ck1,clf
        [Test]
        [Category("CatAPITests")]
        public void SaveFavourite()
        {
            var imageid = "aqo";
            FavouritesSaveImage catAPI = new FavouritesSaveImage();
            var response = catAPI.SaveImageAsFavourite(imageid);

            Assert.That(response.StatusCode.ToString(), Is.EqualTo("OK"));

        }

        //get a specific favourite by sending the imageId
        //ids which can be used - 100098828,100098831,100098855,100098856
        [Test]
        [Category("CatAPITests")]
        public void getSpecificFavourite()
        {
            GetSpecificFavourite catAPI = new GetSpecificFavourite();

            var imageID = "100098828";
            var response = catAPI.GetASpecificFavourite(imageID);
            var responseContent = response.Content.ToString();
            string expectedURL = "https://cdn2.thecatapi.com/images/9ccXTANkb.jpg";

            //convert the whole string response into an object which will make it easier to perform assertions on
            var jsonResponse = JsonConvert.DeserializeObject<SpecificFavouriteObject>(responseContent);

            //verify status code
            Assert.That(response.StatusCode.ToString(), Is.EqualTo("OK"));

            //method 1 - verify whole body as string
            Assert.That(responseContent, Is.EqualTo("{\"id\":100098828,\"user_id\":\"acpk4r\",\"image_id\":\"9ccXTANkb\",\"sub_id\":\"your-user-dara\",\"created_at\":\"2022-11-13T10:25:18.000Z\",\"image\":{\"id\":\"9ccXTANkb\",\"url\":\"https://cdn2.thecatapi.com/images/9ccXTANkb.jpg\"}}"));
            
            //method 2 - verify specific field
            Assert.That(jsonResponse.image.url, Is.EqualTo(expectedURL));
        }

        //Delete a favourite by passing the id
        //set favouriteId variable with one of the following ids in order to get a successful test, otherwise will be bad request as not available
        //100098855,100098831,100098856
        [Test]
        [Category("CatAPITests")]
        public void DeleteFavourite()
        {
            var favouriteId = "";
            DeleteAFavourite catAPI = new DeleteAFavourite();
            var response = catAPI.DeleteFavourite(favouriteId);

            Assert.That(response.StatusCode.ToString(), Is.EqualTo("OK"));

        }

    }



}
