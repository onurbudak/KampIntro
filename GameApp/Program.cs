using GameApp.Adapters;
using GameApp.Concrete;
using GameApp.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(
                new UserValidationService(new MyServiceAdapter()),
                new CampaignManager(),
                new SalesManager(),
                new Game { Id = 1, GameName = "GTA5", UnitPrice = 200 },
                new Campaign { Id = 1, CampaignName = "Muhteşem Cuma", DiscountRate = 7 });
            gamerManager.Add(new Gamer { Id = 1, FirstName = "ONUR", LastName = "BUDAK", NationalityId = "123456", BirthYear = 1997 });

            //List<Reservation> reservationList = new List<Reservation>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://wuhan-coronavirus-api.laeyoung.endpoint.ainize.ai/jhu-edu/latest"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        reservationList = JsonConvert.DeserializeObject<List<Reservation>>(apiResponse);

            //        foreach (var item in reservationList)
            //        {
            //            Console.WriteLine(item.countryregion);
            //        }


            //    }
            //}
            Console.ReadLine();

        }
    }
}
