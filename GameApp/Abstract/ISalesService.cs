using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public interface ISalesService
    {
        void Sell(Game game, Campaign campaign);
    }
}
