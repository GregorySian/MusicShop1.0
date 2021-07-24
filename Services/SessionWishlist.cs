using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MusicHub.Infrastructure;
using MusicHub.Models;
using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MusicHub.Services
{
    public class SessionWishlist: Wishlist
    {
        public static Wishlist GetWishlist(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionWishlist wishlist= session?.GetJson<SessionWishlist>("Wishlist") ?? new SessionWishlist();
            wishlist.session = session;
            return wishlist;
        }

        private ISession session { get; set; }

        public override void AddItems(Album album, string wishlistId)
        {
            base.AddItems(album, wishlistId);
            session.SetJson("Wishlist", this);
        }

        public override void RemoveLine(Album album)
        {
            base.RemoveLine(album);
            session.SetJson("Wishlist", this);
        }

        public override void Clear()
        {
            base.Clear();
            session.Remove("Wishlist");
        }
    }
}
