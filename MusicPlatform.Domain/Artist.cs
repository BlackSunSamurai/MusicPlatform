namespace MusicPlatform.Domain;

public class Artist : BaseEntity
{
    public string ArtistName  { get; set; }
    public string ArtistPhoto { get; set; }
    
    public ICollection<ArtistSong> ArtistSongs { get; set; }
}