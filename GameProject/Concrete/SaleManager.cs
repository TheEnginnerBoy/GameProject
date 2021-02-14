using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + campaign.Name + " ile " + game.Name + " oyununu satın aldı." + '\n');
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" "+gamer.LastName+" "+ game.Name + " oyununu satın aldı." + '\n');
        }
    }
}
