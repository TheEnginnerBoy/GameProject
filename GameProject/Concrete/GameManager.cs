using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Silindi." + '\n');
        }

        public void Save(Game game)
        {
            Console.WriteLine(game.Name + " Eklendi." + '\n');
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Güncellendi." + '\n');
        }
    }
}
