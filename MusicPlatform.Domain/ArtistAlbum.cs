namespace MusicPlatform.Domain;

public class ArtistAlbum
{
    public Artist Artist   { get; set; }
    public int    ArtistId { get; set; }
    
    public Album  Album    { get; set; }
    public int    AlbumId  { get; set; }
}