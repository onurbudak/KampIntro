using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public int Add(Game game, Campaign campaign)
        {
            var resultCampaign = (game.UnitPrice - ((game.UnitPrice * campaign.DiscountRate)/ 100));
            return resultCampaign;
      
        }

        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
