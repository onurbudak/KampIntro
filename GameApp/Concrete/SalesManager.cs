using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(ICampaignService campaignService, Game game,Campaign campaign)
        {
            var resultUnitPrice = campaignService.Add(game,campaign);
            Console.WriteLine("{0} oyunu {1} kampanyası ile {2} tl' ye satildi.",game.GameName, campaign.CampaignName,resultUnitPrice);
        }
    }
}
