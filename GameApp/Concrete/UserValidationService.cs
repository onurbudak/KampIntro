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

           //if(gamer.Id == 1 && gamer.FirstName == "Onur" && gamer.LastName == "Budak" && gamer.NationalityId == "123456" && gamer.BirthYear == 1997)
           // {
           //     return true;
           // }
           //else
           // {
           //     return false;
           // }
        }
    }
}
