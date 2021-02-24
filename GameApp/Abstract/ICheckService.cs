using GameApp.Entities;

namespace GameApp.Abstract
{
    public interface ICheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}