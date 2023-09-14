namespace RoutingLogic.Models
{
    public class SongDto
    {
        public int Id { get; set; }
        public string Name { get; set; } =string.Empty;
        

        public string Singer { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string AlbumCover { get; set; } = string.Empty;

        public string DateReleased { get; set; } = string.Empty;

        public int CopiesSold { get; set; } 
    }
}
