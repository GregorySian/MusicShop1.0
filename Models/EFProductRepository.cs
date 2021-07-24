using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicHub.Data;
using MusicHub.Interfaces;

namespace MusicHub.Models
{
    public class EFAlbumRepository : IAlbumRepository
    {
        private readonly ApplicationDbContext _context;

        public EFAlbumRepository(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Album> Albums => _context.Albums;
    }
}
