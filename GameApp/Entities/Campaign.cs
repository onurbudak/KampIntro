using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
    }
}
