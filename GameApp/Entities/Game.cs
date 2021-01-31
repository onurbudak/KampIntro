using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int UnitPrice { get; set; }
    }
}
