using System.Linq;
using MusicHub.Models;

namespace MusicHub.ViewModels
{
    public class AlbumsListViewModel
    {
        public IQueryable<Album> Albums{ get; set; }
        public PaginationInfoViewModel PaginationInfo { get; set; }
        public string CurrentGenre { get; set; }


    }
}
