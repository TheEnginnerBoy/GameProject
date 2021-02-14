using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.FirstName=="ismail" && gamer.LastName=="Bozkurt" && gamer.NationalityId=="12345678912")
            {
                return true;
            }
            else if(gamer.Id == 2 && gamer.FirstName == "Emir" && gamer.LastName == "Bozkurt" && gamer.NationalityId == "98765432112")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
