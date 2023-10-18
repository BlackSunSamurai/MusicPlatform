namespace MusicPlatform.Domain;

public class Song : BaseEntity
{
    public string SongName  { get; set; }
    
    public string SongPhoto { get; set; }
    
    public string Lyrics    { get; set; }
    
    public string SongURL   { get; set; }
    
    public Album? Album     { get; set; }
    public Album  AlbumId   { get; set; }
    
    public Artist Artist    { get; set; }
    public int    ArtistId  { get; set; }
}