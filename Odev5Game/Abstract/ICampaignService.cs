using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Abstract
{
    public interface ICampaignService
    {
        void Login(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }

}
