using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class GamerManager : IGamerServices
    {
        private ICheckService _govermentCheck;

        public GamerManager(ICheckService govermentCheck)
        {
            _govermentCheck = govermentCheck;
        }

        public void GamerAdd(Gamer gamer)
        {
            if (_govermentCheck.Check(gamer))
                Console.WriteLine(gamer.FirstName + " adli oyuncu sisteme eklendi.");
            else
                throw new Exception("bu oyuncu sisteme kayitli degil");
        }

        public void GamerDeleted(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adli oyuncu sistemden silindi.");
        }

        public void GamerUpdated(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adli oyuncu guncellendi.");
        }
    }
}
