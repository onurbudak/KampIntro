using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Eklendi");
        }

        public abstract void Delete(Gamer gamer);

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
