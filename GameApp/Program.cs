using GameApp.Concrete;
using GameApp.Entities;
using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationService());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Onur", LastName = "Budak", NationalityId = "123456", BirthYear = 1997 });

            SalesManager salesManager = new SalesManager(new CampaignManager());
            salesManager.Sell(new Game { Id = 1, GameName = "GTA5", UnitPrice = 2000 }, new Campaign { Id = 1, CampaignName = "Muhteşem Cuma", DiscountRate = 6 });

            Console.ReadLine();

        }
    }
}
