using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerService = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer {
                Id=1,
                FirstName="ismail",
                LastName="Bozkurt",
                DateOfBirth=new DateTime(1986,8,16),
                NationalityId="12345678912"};

            gamerService.Save(gamer);


            Gamer gamer2 = new Gamer {
                Id = 2,
                FirstName = "Emir",
                LastName = "Bozkurt",
                DateOfBirth = new DateTime(1986, 8, 16),
                NationalityId = "98765432112"
            };
            gamerService.Save(gamer2);
            gamerService.Update(gamer);
            gamerService.Delete(gamer2);

            Console.WriteLine("==========================================================");
            
            IGameService gameService = new GameManager();
            Game game1 = new Game { Id = 1, Name = "Call Of Duty", Price = 10 };
            Game game2 = new Game { Id = 2, Name = "Far Cry 5", Price = 15 };
            gameService.Save(game1);
            gameService.Delete(game2);
            gameService.Update(game1);

            Console.WriteLine("==========================================================");

            ICampaignService campaignService = new CampaignManager();
            Campaign campaign1 = new Campaign { Id = 1, Name = "Yeni Yıl Kampanyası", DiscountRate = 10 };
            campaignService.Save(campaign1);
            campaignService.Update(campaign1);
            campaignService.Delete(campaign1);

            Console.WriteLine("==========================================================");

            ISaleService saleService = new SaleManager();
            saleService.Sales(game1, gamer);
            saleService.CampaignSales(game2, gamer2, campaign1);


        }
            
    }

 
}
