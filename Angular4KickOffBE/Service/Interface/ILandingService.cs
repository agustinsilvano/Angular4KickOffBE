﻿using Angular4KickOffBE.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular4KickOffBE.Service.Interface
{
    public interface ILandingService
    {
        IList<LandingDTO> GetLandings();
    }
}
