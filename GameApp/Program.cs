using GameApp.Adapters;
using GameApp.Concrete;
using GameApp.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace GameApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(
                new UserValidationService(new MyServiceAdapter()),
                new CampaignManager(),
                new SalesManager(),
                new Game { Id = 1, GameName = "GTA5", UnitPrice = 200 },
                new Campaign { Id = 1, CampaignName = "Muhteşem Cuma", DiscountRate = 7 });
            gamerManager.Add(new Gamer { Id = 1, FirstName = "ONUR", LastName = "BUDAK", NationalityId = "123456", BirthYear = 1997 });

            Console.WriteLine("-------------------------------------------------------------------------");

            await RemoteApiCall1();

            Console.WriteLine("-------------------------------------------------------------------------");

            await RemoteApiCall2();

            //Console.ReadLine();

        }

        private static async Task RemoteApiCall1()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://wuhan-coronavirus-api.laeyoung.endpoint.ainize.ai/jhu-edu/latest"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    List<Reservation> reservationList = JsonConvert.DeserializeObject<List<Reservation>>(apiResponse);

                    foreach (var item in reservationList)
                    {
                        Console.WriteLine(item.countryregion);
                    }


                }
            }
        }

        private static async Task RemoteApiCall2()
        {
            const string BASE_URL = "https://api4all.azurewebsites.net";

            using (var httpClient = new HttpClient())
            {
                var client = new swaggerClient(BASE_URL, httpClient);
                var items = await client.StudentsAllAsync();
                foreach (var i in items)
                {
                    Console.WriteLine($"{i.StudentId}\t{i.FirstName}\t{i.LastName}\t{i.School}");
                }
            }
        }
    }
}
