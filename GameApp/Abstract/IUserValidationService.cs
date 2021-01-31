using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public interface IUserValidatonService
    {
        bool Validate(Gamer gamer);
    }
}
