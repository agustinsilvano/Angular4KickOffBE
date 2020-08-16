using Angular4KickOffBE.DTO;
using Angular4KickOffBE.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular4KickOffBE.Service
{
    public class LandingService : ILandingService
    {
        public IList<LandingDTO> GetLandings()
        {
            IList<LandingDTO> res = new List<LandingDTO>();

            LandingDTO e1 = new LandingDTO
            {
                Title = "Google",
                Description = "Primer elemento !",
                Url = @"https://s5.eestatic.com/2015/10/03/actualidad/Actualidad_68753203_129196255_1024x576.jpg"
            };

            res.Add(e1);

                LandingDTO e2 = new LandingDTO
            {
                Title = "Yahoo",
                Description = "Segundo elemento!",
                Url = @"https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/media/image/2016/06/174984-yahoo-messenger.jpg"
            };

            res.Add(e2);

            LandingDTO e3 = new LandingDTO
            {
                Title = "Bing",
                Description = "Tercer elemento!",
                Url = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRInzJY2KARb3UXofnsifofXitS6e5KLI-sdIKCHi-2yebFJlSx&s"
            };

            res.Add(e3);

            return res;
        }
    }
}
