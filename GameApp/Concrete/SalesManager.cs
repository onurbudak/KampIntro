using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public class SalesManager : ISalesService
    {
        ICampaignService _campaignService;

        public SalesManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sell(Game game,Campaign campaign)
        {
            var result =  _campaignService.Add(game,campaign);
            Console.WriteLine("Oyun {0} kampanyası ile {1} tl fiyatla Satıldı", campaign.CampaignName,game.UnitPrice);
        }
    }
}
