﻿using GameApp.Adapters;
using GameApp.Concrete;
using GameApp.Entities;
using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(
                new UserValidationService(new MernisServiceAdapter()),
                new CampaignManager(),
                new SalesManager(),
                new Game { Id = 1, GameName = "GTA5", UnitPrice = 200 },
                new Campaign { Id = 1, CampaignName = "Muhteşem Cuma", DiscountRate = 7 });
            gamerManager.Add(new Gamer { Id = 1, FirstName = "UĞUR", LastName = "BUDAK", NationalityId = "123456", BirthYear = 2000 });

            Console.ReadLine();

        }
    }
}
