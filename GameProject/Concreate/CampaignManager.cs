using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class CampaignManager : ICampaignServices
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanya sisteme eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya sistemden silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya guncellendi.");
        }
    }
}
