using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Adapters
{
    public class MyServiceAdapter : ICheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "ONUR" && gamer.LastName == "BUDAK" && gamer.NationalityId == "123456" && gamer.BirthYear == 1997)
            {
                Console.WriteLine("MyServiceAdapter ile kontrol edildi");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
