using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular4KickOffBE.DTO;
using Angular4KickOffBE.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Angular4KickOffBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedController : ControllerBase
    {

        private readonly ILogger<FeedController> _logger;
        private readonly IFeedService _feedService;

        public FeedController(ILogger<FeedController> logger, IFeedService fs)
        {
            _logger = logger;
            _feedService = fs;
        }

        [HttpGet, HttpOptions]
        [AllowAnonymous]
        [ProducesResponseType(200, Type = typeof(IList<FeedDTO>))]
        //[Produces("application/json")]
        public IActionResult Get([FromQuery] int feedId )
        {
            _logger.LogInformation("Lista de feeds solicitada.");

            IList<FeedDTO> feeds = _feedService.GetFeeds(feedId);

            return Ok(feeds);
        }

        [HttpGet("test")]
        [ProducesResponseType(200,Type= typeof(string))]
        public IActionResult Test()
        {
            return Ok("Hola.");
        }
    }
}
