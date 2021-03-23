using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Abstract
{
    public interface IGameService
    {
        void SellNormal(Customer customer, Game game);
        void SellWithCampaign(Customer customer, Game game, Campaign campaign);
    }
}
