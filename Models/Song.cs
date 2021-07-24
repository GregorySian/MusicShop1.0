
namespace MusicHub.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Album Name { get; set; }
        
        public int Duration { get; set; }
    }
}
