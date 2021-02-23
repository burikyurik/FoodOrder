using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Search restaurants menu items by keyword and location.
        /// </summary>
        /// <param name="searchKeyword">Menu item name or category.</param>
        /// <param name="location">Restaurants location.</param>
        /// <param name="token"></param>
        /// <returns>Founded list of restaurants with menu items.</returns>
        [HttpGet("search")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetMenuItems(string searchKeyword, string location, CancellationToken token = default)
        {
            var restaurants = await _mediator.Send(new SearchRestaurantQuery(searchKeyword, location), token);
            return Ok(restaurants);
        }
    }
}