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
        Game _game;
        Campaign _campaign;

        public GamerManager(IUserValidatonService userValidatonService, ICampaignService campaignService, ISalesService salesService,Game game, Campaign campaign)
        {
            _userValidatonService = userValidatonService;
            _campaignService = campaignService;
            _salesService = salesService;
            _game = game;
            _campaign = campaign;

        }

        public override void Add(Gamer gamer)
        {
            if (_userValidatonService.Validate(gamer))
            {
                base.Add(gamer);
                _salesService.Sell(_campaignService, _game, _campaign);
            }
            else
            {
                Console.WriteLine("Not a valid user");
            }

        }

        public override void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
