using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MusicHub.Models;
using MusicHub.Models.Cart;
using MusicHub.Infrastructure;
using Newtonsoft.Json;
using System;

namespace MusicHub.Services
{
    public class SessionCart : Cart 
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItems(Album album , int quantity)
        {
            base.AddItems(album, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Album album)
        {
            base.RemoveLine(album);
            Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
