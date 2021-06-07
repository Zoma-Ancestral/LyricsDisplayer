
public class RequestResponse
{
    public Meta Meta { get; set; }
    public Response Response { get; set; }
}

public class Meta
{
    public int Status { get; set; }
    public string Message { get; set; }
}

public class Response
{
    public Hit[] Hits { get; set; }
}

public class Hit
{
    public object[] Highlights { get; set; }
    public string Index { get; set; }
    public string Type { get; set; }
    public Result Result { get; set; }
}

public class Result
{
    public int Annotation_count { get; set; }
    public string Api_path { get; set; }
    public string Full_title { get; set; }
    public string Header_image_thumbnail_url { get; set; }
    public string Header_image_url { get; set; }
    public int Id { get; set; }
    public int Lyrics_owner_id { get; set; }
    public string Lyrics_state { get; set; }
    public string Path { get; set; }
    public int? Pyongs_count { get; set; }
    public string Song_art_image_thumbnail_url { get; set; }
    public string Song_art_image_url { get; set; }
    public Stats Stats { get; set; }
    public string Title { get; set; }
    public string Title_with_featured { get; set; }
    public string Url { get; set; }
    public string Song_art_primary_color { get; set; }
    public string Song_art_secondary_color { get; set; }
    public string Song_art_text_color { get; set; }
    public Primary_Artist Primary_artist { get; set; }
}

public class Stats
{
    public int Unreviewed_annotations { get; set; }
    public int Concurrents { get; set; }
    public bool Hot { get; set; }
    public int Pageviews { get; set; }
}

public class Primary_Artist
{
    public string Api_path { get; set; }
    public string Header_image_url { get; set; }
    public int Id { get; set; }
    public string Image_url { get; set; }
    public bool Is_meme_verified { get; set; }
    public bool Is_verified { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public int Iq { get; set; }
}
