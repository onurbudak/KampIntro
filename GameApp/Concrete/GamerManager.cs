using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        IUserValidatonService _userValidatonService;
        ICampaignService _campaignService;
        ISalesService _salesService;

        public GamerManager(IUserValidatonService userValidatonService, ICampaignService campaignService, ISalesService salesService)
        {
            _userValidatonService = userValidatonService;
            _campaignService = campaignService;
            _salesService = salesService;

        }

        public override void Add(Gamer gamer, Game game, Campaign campaign)
        {
            if (_userValidatonService.Validate(gamer))
            {
                
                base.Add(gamer, game, campaign);
                _salesService.Sell(_campaignService, game, campaign);
            }
            else
            {
                Console.WriteLine("Not a valid user");
            }

        }

        public override void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
