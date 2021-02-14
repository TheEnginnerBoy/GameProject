using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "'nın süresi dolduğundan kampanya silindi." + '\n');
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi! : " + campaign.Name + " İndirim Oranı: " + campaign.DiscountRate + '\n');
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi! : " + campaign.Name + " İndirim Oranı : " + campaign.DiscountRate + '\n');
        }
    }
}
