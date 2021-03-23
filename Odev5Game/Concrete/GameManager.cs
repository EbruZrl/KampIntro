using Odev5Game.Abstract;
using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Concrete
{
    public class GameManager : IGameService
    {
        public void SellNormal(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + game.Id + game.Name +" " +
                "oyununu aldığınız için teşekkür ederiz." + " " + "Ürünün fiyatı:" + " " + game.price);
        }

        public void SellWithCampaign(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + game.Id + game.Name + " " +
                "oyununu" + " " +campaign.Id + campaign.Name + " " + "kampanyası sayesinde %" + campaign.OfferPrice + " " +
                "indirimle aldınız. Teşekkür ederiz." + " " + "Ürünün indirimli fiyatı" + " " + game.price);
        }
    }
}
