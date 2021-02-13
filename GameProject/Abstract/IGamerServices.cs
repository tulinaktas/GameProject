using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGamerServices
    {
        public void GamerAdd(Gamer gamer);
        public void GamerDeleted(Gamer gamer);
        public void GamerUpdated(Gamer gamer);

    }
}
