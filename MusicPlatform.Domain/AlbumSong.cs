namespace MusicPlatform.Domain;

public class AlbumSong
{
    public Album Album   { get; set; }
    public int   AlbumId { get; set; }
    
    public Song  Song    { get; set; }
    public int   SongId  { get; set; }
}