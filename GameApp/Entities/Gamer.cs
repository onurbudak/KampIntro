using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string NationalityId { get; set; }
    }
}
