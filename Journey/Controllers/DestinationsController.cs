using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Journey.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Journey.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {

        private readonly JournyDbContext _journyDb;
        private readonly ILogger<DestinationsController> _logger;
        public DestinationsController(JournyDbContext journyDb, ILogger<DestinationsController> logger)
        {
            _journyDb = journyDb;
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into DestinationsController");
        }


        [HttpGet("byId")]
        public async Task<IActionResult> Get(int id)
        {

            try
            {
                var data = from d in _journyDb.Destinations
                           where d.IsDeleted==0 && d.IsPublished==1 && d.DestinationId==id
                           select new
                           {
                               d.DestinationId,
                               d.DestinationName,
                               d.ShortDescription,
                               d.EnjoyableTime,
                               d.AdditonalInformation,
                               d.VisitedOn,
                               d.IsPublished,
                               d.CatagoryId,
                               d.CreatedUserId,
                               d.TravellingModeId,
                               d.AdminId,
                               DestinationImages =d.DestinationImages.Select(i => new { i.DestinationImageId, i.ImageCaption, i.Url, i.DestinationId }),
                               Attractions = d.Attractions.Where(a=>a.IsDeleted!=1 && a.IsPublished==1).Select(a => new { a.AttractionId, a.AttractionName, a.CreatedUserId, a.ShortDescription }),
                               UserFeedbacks=d.UserFeedbacks.Select(f => new { f.UserFeedbackId,f.Rating,f.Comment,f.UserId,f.User.Username }),
                               DestinationPopularity=d.DestinationPopularities.Select(p => new { p.DestinationPopularityId , p.TypeId,p.PopularityType.Name,p.value}),
                               NearbyDestination=d.NearbyDestinationSuggestions.Select(nd =>new { nd.NearbyDestinationSuggestionId,nd.SuggestedDestinationName})
                           };


                   


                return Ok(new { message = "Data Received Succesfully",Data=data.FirstOrDefault() });
            }
            catch (Exception e) {

                _logger.LogError(2, e.Message, "");
                return BadRequest(e.Message);
            }
        }


    }
}