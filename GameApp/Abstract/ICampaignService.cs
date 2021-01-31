using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public interface ICampaignService
    {
        int Add(Game game, Campaign campaign);
        void Delete(Game game, Campaign campaign);
        void Update(Game game, Campaign campaign);
    }
}
