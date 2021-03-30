using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager
    {
        public void Sales(Game game, User user, Campaign campaign)
        {
            Console.WriteLine(user.UserFirstName + " " + user.UserLastName + " isimli oyuncu " + game.GameName + " oyununu " 
                + campaign.CampaignName + " kampanyasıyla % " + campaign.DiscountRate + "indirim ile " + game.GamePrice + " TL'ye satın almıştır.");
            Console.WriteLine("**************************************************************************************************************");
        }
    }
}
