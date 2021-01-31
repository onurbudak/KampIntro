using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
