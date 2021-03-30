using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.UserId = 1;
            user1.UserFirstName = "Betülay";
            user1.UserLastName = "Namver";
            user1.DateOfBirth =  new DateTime(2000,9,21);
            user1.NationalityId = "12345678900";
            User user2 = new User { UserId = 2, UserFirstName = "Can", UserLastName = "Yüksel", NationalityId = "12456930785", DateOfBirth = new DateTime(1993,2,16) };
            User user3 = new User { UserId = 3, UserFirstName = "Mehmet", UserLastName = "Namver", NationalityId = "12348450785", DateOfBirth = new DateTime(1998,9,21) };

            UserManager userManager = new UserManager();
            userManager.Add(user3);
            userManager.Delete(user2);
            userManager.Update(user1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { CampaignId = 101, CampaignName = "Harika Fırsat", DiscountRate = 30 });
            campaignManager.Delete(new Campaign { CampaignId = 101, CampaignName = "Harika Fırsat", DiscountRate = 30 });
            campaignManager.Update(new Campaign { CampaignId = 101, CampaignName = "Harika Fırsat", DiscountRate = 30 });

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(new Game { GameId = 1, GameName = "Sims", GamePrice = 180 },
                               new User { UserId = 4, UserFirstName = "İlayda", UserLastName = "Saraç", DateOfBirth = new DateTime(2000,8,4), NationalityId = "13658742964"},
                               new Campaign {CampaignId = 101, CampaignName = "Harika Fırsat", DiscountRate = 30 });
        }     
    }
}
