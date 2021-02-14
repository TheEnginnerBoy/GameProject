using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService )
        {
            this._userValidationService = userValidationService;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "'nın kaydı silindi" + '\n');
        }

        public void Save(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName +" "+gamer.LastName+ " Kayıt oldu" + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama Yapılamadı. Kayıt Başarısız." + '\n');
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "'nın kaydı güncellendi" + '\n');
        }
    }
}
