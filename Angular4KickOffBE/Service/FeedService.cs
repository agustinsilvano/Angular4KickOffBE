using Angular4KickOffBE.DTO;
using Angular4KickOffBE.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular4KickOffBE.Service
{
    public class FeedService : IFeedService
    {
        public static int Id = 1;

        public IList<FeedDTO> GetFeeds()
        {
            IList<FeedDTO> result = new List<FeedDTO>();

            FeedDTO f1 = new FeedDTO
            {
                Id = FeedService.Id,
                Title = "Estamos de viaje!",
                Content = "Estamos yendo de joda."
            };
            
            FeedService.Id++;

            result.Add(f1);

            FeedDTO f2 = new FeedDTO
            {
                Id = FeedService.Id,
                Title = "Vuelta al laburo",
                Content = "Estamos yendo a laburar."
            };

            FeedService.Id++;

            result.Add(f2);

            FeedDTO f3 = new FeedDTO
            {
                Id = FeedService.Id,
                Title = "Aprendiendo angular.",
                Content = "Pa' aprender y volar!!!!!"
            };

            FeedService.Id++;

            result.Add(f3);

            return result;
        }
    }
}
