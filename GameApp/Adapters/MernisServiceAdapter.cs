using System;
using System.Collections.Generic;
using System.Text;
using GameApp.Abstract;
using GameApp.Entities;
using MernisServiceReference;

namespace GameApp.Adapters
{
    public class MernisServiceAdapter:ICheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result =  client.TCKimlikNoDogrulaAsync((long)Convert.ToUInt64( gamer.NationalityId),gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
            return result;
        }
    }
}
