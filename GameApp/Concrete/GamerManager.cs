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

        public GamerManager(IUserValidatonService userValidatonService)
        {
            _userValidatonService = userValidatonService;
        }

        public override void Add(Gamer gamer)
        {
            if (_userValidatonService.Validate(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid user");
            }

        }

        public override void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
