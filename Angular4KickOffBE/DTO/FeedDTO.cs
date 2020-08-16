using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular4KickOffBE.DTO
{
    public class FeedDTO
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public string Content { get; set; }

        public string SLA { get; set; }

        //ctor
        public FeedDTO() { }



    }
}
