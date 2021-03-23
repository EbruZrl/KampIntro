using Odev5Game.Abstract;
using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Concrete
{
    public class CampaignManager : ICampaignService

    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Login(Campaign campaign)
        {
            Console.WriteLine("Kampanya girildi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }


}
