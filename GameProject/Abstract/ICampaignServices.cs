using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignServices
    {
        public void Add(Campaign campaign);
        public void Update(Campaign campaign);
        public void Delete(Campaign campaign);
    }
}
