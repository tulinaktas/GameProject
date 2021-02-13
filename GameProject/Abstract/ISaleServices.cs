using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleServices
    {
        public void Sale(Game game, Gamer gamer);
        public void CampaignSale(Game game, Campaign campaign, Gamer gamer);
    }
}
