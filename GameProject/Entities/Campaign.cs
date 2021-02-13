using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName{ get; set; }
        public int CampaignAmount { get; set; }
    }
}
