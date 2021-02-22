using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Business.Query;
using FoodOrder.Business.Dtos;
using MediatR;

namespace FoodOrder.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
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
        public async Task<IActionResult> GetMenuItems(string searchKeyword, string location, CancellationToken token = default)
        {
            var restaurants = await _mediator.SendAsync(new SearchRestaurantQuery(searchKeyword, location), token);
            return Ok(restaurants);
        }

        [HttpPost("order")]
        public async Task<IActionResult> CreateOrders(string searchKeyword, string location, CancellationToken token = default)
        {
            var redcurrants = await _mediator.SendAsync<ICollection<RestaurantMenuDto>>(new SearchRestaurantQuery(searchKeyword, location), token);
            return Ok(redcurrants);
        }

        [Route("{orderId:int}")]
        public async Task<IActionResult> GetOrder(string searchKeyword, string location, CancellationToken token = default)
        {
            var redcurrants = await _mediator.SendAsync<ICollection<RestaurantMenuDto>>(new SearchRestaurantQuery(searchKeyword, location), token);
            return Ok(redcurrants);
        }
    }
}
