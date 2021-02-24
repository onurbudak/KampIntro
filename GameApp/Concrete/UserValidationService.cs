using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public class UserValidationService : IUserValidatonService
    {
        ICheckService _checkService;

        public UserValidationService(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public bool Validate(Gamer gamer)
        {

           var result =  _checkService.CheckIfRealPerson(gamer);
           return result;
          
        }
    }
}
