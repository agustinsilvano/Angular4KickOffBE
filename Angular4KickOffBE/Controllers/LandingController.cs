using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular4KickOffBE.DTO;
using Angular4KickOffBE.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular4KickOffBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LandingController : ControllerBase
    {
        private readonly ILogger<LandingController> _logger;
        private readonly ILandingService _landingService;

        public LandingController(ILogger<LandingController> logger ,ILandingService landingService)
        {
            _logger = logger;
            _landingService = landingService;
        }

        [HttpGet, HttpOptions]
        [AllowAnonymous]
        [ProducesResponseType(200, Type = typeof(IList<LandingDTO>))]
        public IActionResult LandingData()
        {
            _logger.LogInformation("Landing Data solicitada!");
            return Ok(_landingService.GetLandings());
        }

        

    }
}
