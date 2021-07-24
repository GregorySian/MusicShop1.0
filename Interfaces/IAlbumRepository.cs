using System;
using System.Collections.Generic;
using System.Linq;
using MusicHub.Models;

namespace MusicHub.Interfaces
{
   public interface IAlbumRepository
   {
       IQueryable<Album> Albums { get; }
   }
}
