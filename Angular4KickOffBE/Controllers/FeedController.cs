using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular4KickOffBE.DTO;
using Angular4KickOffBE.Service.Interface;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        [AllowAnonymous]
        //ProducesResponseType(200, Type = typeof(IList<FeedDTO>))]
        //[Produces("application/json")]
        public IActionResult Get()
        {
            _logger.LogInformation("Lista de feeds solicitada.");

            IList<FeedDTO> feeds = _feedService.GetFeeds();

            return Ok(feeds);
        }
    }
}
