using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class SaleManager : ISaleServices
    {
        public void CampaignSale(Game game, Campaign campaign, Gamer gamer)
        {
            game.Price = game.Price - campaign.CampaignAmount;
            Console.WriteLine("Sayin "+gamer.FirstName+", "+game.GameName+" adli oyunu "
                +campaign.CampaignName+" adli kampanyadan "+campaign.CampaignAmount+" tl indirim ile "+game.Price+" tlye sahip oldunuz!");

        }

        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine("Tebrikler, "+gamer.FirstName+"! "+game.GameName+" adli oyunu satin aldiniz!");
        }
    }
}
