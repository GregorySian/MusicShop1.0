using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace MusicHub.Models
{
    public class Wishlist
    {
        private List<WishlistLine> _wishlists = new List<WishlistLine>();
        public virtual void AddItems(Album album, string wishlistId)
        {
            WishlistLine wishlist = _wishlists.Where(a => a.Album.Id == album.Id).FirstOrDefault();

            if (wishlist == null)
            {
                _wishlists.Add(new WishlistLine
                {
                    WishlistLineId = wishlistId,
                    Album = album
                });

            }
            else
            {
                _wishlists.Add(wishlist);
            }
        }
        public virtual void RemoveLine(Album album)
        {
            _wishlists.RemoveAll(w => w.Album.Id == album.Id);
        }

        public virtual void Clear() => _wishlists.Clear();
        public IEnumerable<WishlistLine> Lines => _wishlists;

        public class WishlistLine
        {
            public string WishlistLineId { get; set; }
            public Album Album { get; set; }
        }

    }
}