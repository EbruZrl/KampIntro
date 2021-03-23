using Odev5Game.Abstract;
using Odev5Game.Adapters;
using Odev5Game.Concrete;
using Odev5Game.Entities;
using System;

namespace Odev5Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Ebru";
            customer1.LastName = "Zorlu";
            customer1.NationalityId="123456789";

            BaseCustomerManager customerManager2 = new CustomerManager(new MernisServiceAdapter());
            customerManager2.Add(new Customer
            {
                NationalityId = "30332280800",
                FirstName = "Ebru",
                LastName = "Zorlu",
                DateOfBirth = new System.DateTime(2000, 7, 14)
                
            }
                );

            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Save(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);


            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "Sezon Sonu Fırsatları";
            campaign.OfferPrice = 50;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Login(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);
            

            Game game = new Game();
            game.Id = 2;
            game.Name = "Phasmophobia";
            game.price = 20;

            GameManager gameManager = new GameManager();
            gameManager.SellNormal(customer1, game);
            gameManager.SellWithCampaign(customer1, game, campaign);
        }
    }
}
