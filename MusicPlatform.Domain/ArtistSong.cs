namespace MusicPlatform.Domain;

public class ArtistSong  
{
    public Artist Artist   { get; set; }
    public int    ArtistId { get; set; }
    
    public Song   Song     { get; set; }
    public int    SongId   { get; set; }
}