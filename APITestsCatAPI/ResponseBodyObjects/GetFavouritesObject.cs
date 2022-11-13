
public class Favourites
{
    public int id { get; set; }
    public string user_id { get; set; }
    public string image_id { get; set; }
    public string sub_id { get; set; }
    public DateTime created_at { get; set; }
    public FavouriteImage image { get; set; }
}

public class FavouriteImage
{
    public string id { get; set; }
    public string url { get; set; }
}


