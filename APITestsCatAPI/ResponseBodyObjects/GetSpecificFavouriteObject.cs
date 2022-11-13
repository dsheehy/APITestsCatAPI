
public class SpecificFavouriteObject
{
    public int id { get; set; }
    public string user_id { get; set; }
    public string image_id { get; set; }
    public string sub_id { get; set; }
    public DateTime created_at { get; set; }
    public Image image { get; set; }
}

public class Image
{
    public string id { get; set; }
    public string url { get; set; }
}
