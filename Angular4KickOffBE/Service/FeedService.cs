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

        public IList<FeedDTO> feeds = new List<FeedDTO>();

        public IList<FeedDTO> GetFeeds(int feedId)
        { 
            if(feeds.Count == 0)
            {
                this.seedData();
            }
            
            if (feedId > 0)
            {
                feeds = feeds.Where(f => f.Id == feedId).ToList(); 
            }

            return feeds;
        }

        public FeedDTO AddFeed(FeedDTO input)
        {
            input.Id = FeedService.Id;
            
            FeedService.Id++;

            feeds.Add(input);

            return input;
        }

        #region Utils
        public void seedData()
        {
            FeedDTO f1 = new FeedDTO
            {
                Id = FeedService.Id,
                Title = "Estamos de viaje! 11",
                Content = "Estamos yendo de joda."
            };

            FeedService.Id++;

            feeds.Add(f1);

            FeedDTO f2 = new FeedDTO
            {
                Id = FeedService.Id,
                Title = "Vuelta al laburo",
                Content = "Estamos yendo a laburar. Coso!"
            };

            FeedService.Id++;

            feeds.Add(f2);

            FeedDTO f3 = new FeedDTO
            {
                Id = FeedService.Id,
                Title = "Aprendiendo angular.",
                Content = "Pa' aprender y volar"
            };

            FeedService.Id++;

            feeds.Add(f3);
        }
        #endregion
    }
}
