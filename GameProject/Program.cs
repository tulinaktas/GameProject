using GameProject.Abstract;
using GameProject.Concreate;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() {
                Id = 1,
                FirstName = "Tulin",
                LastName = "Aktas",
                Tc = "000000",
                BirthDate = new DateTime(1998, 09, 18)
        };
            Game game1 = new Game()
            {
                GameId = 1,
                GameName = "Phasmophobia",
                Price = 30
            };
            Game game2 = new Game()
            {
                GameId = 2,
                GameName = "Counter Strike",
                Price = 120
            };
            Game game3 = new Game()
            {
                GameId = 3,
                GameName = "Detroit",
                Price = 220
            };

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "Yeni Uyelik Kampanyasi",
                CampaignAmount = 30
            };

            Campaign campaign2 = new Campaign()
            {
                CampaignId = 2,
                CampaignName = "Oyun Haftasi Kampanyasi",
                CampaignAmount = 20
            };

            ICheckService govermentCheck = new GovermentCheckManager();

            GamerManager gamerManager = new GamerManager(govermentCheck);
            CampaignManager campaignManager = new CampaignManager();
            SaleManager saleManager = new SaleManager();


            campaignManager.Add(campaign1);
            gamerManager.GamerAdd(gamer1);

            saleManager.Sale(game1, gamer1);
            saleManager.CampaignSale(game2, campaign1, gamer1);
            saleManager.CampaignSale(game3, campaign2, gamer1);

        }
    }
}
