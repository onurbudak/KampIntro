﻿using System;
using System.Collections.Generic;
using System.Text;
using GameApp.Abstract;
using GameApp.Entities;
using MernisServiceReference;

namespace GameApp.Adapters
{
    public class MernisServiceAdapter:ICheckService
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        public bool CheckIfRealPerson(Gamer gamer)
        {        
            var result =  client.TCKimlikNoDogrulaAsync((long)Convert.ToUInt64( gamer.NationalityId),gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;

            if(result)
            {
                Console.WriteLine("MernisServiceAdapter ile kontrol edildi");
            }
            return result;
        }
    }
}
