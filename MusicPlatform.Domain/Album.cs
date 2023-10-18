namespace MusicPlatform.Domain;

public class Album : BaseEntity
{
    public string AlbumName  { get; set; }
    public string AlbumPhoto { get; set; }
    
    public ICollection<AlbumSong> AlbumSongs { get; set; }
}