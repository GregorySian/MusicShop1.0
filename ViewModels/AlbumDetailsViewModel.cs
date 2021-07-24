using MusicHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHub.ViewModels
{
    public class AlbumDetailsViewModel
    {
        public Album Albums { get; set; }

        public Genre Name { get; set; }
        public List<Song> Songs { get; set; }
    }
}
