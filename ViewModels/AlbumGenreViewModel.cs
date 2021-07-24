using Microsoft.AspNetCore.Mvc.Rendering;
using MusicHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHub.ViewModels
{
    public class AlbumGenreViewModel
    {
        public List<Album> Albums { get; set; }
        public SelectList Genres { get; set; }
        public string AlbumGenres { get; set; }
        public string SearchString { get; set; }
    }
}
