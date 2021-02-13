using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class GovermentCheckManager : IGovermentCheck
    {
        public bool Check(Gamer gamer)
        {
            //sistemde bir veri var gibi dusunuyoruz o yuzden bu sekilde bir kontrol yapılıyor

            if (gamer.FirstName == "Tulin" && gamer.LastName == "Aktas" && gamer.Tc == "000000" && DateTime.Compare(gamer.BirthDate, new DateTime(1998, 09, 18)) == 0)
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
