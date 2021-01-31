using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {  

        public virtual void Add(Gamer gamer, Game game, Campaign campaign)
        {
          
            Console.WriteLine("{0} isimli oyuncu sisteme girdi.", gamer.FirstName);
        }

        public abstract void Delete(Gamer gamer, Game game, Campaign campaign);

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(" Oyuncu Güncellendi");
        }
    }
}
