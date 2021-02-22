using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Api.Models;
using FoodOrder.Business.Query;
using MediatR;

namespace FoodOrder.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class RestaurantManagementController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantManagementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddRestaurant([FromBody] AddRestaurantRequest addRestaurantRequest, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public async Task<IActionResult> AddRestaurantMeduItems([FromBody] AddRestaurantMenuItemRequest addRestaurantMenu, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task DeleteRestaurant(int id, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("restaurant/{id}/{itemid}")]
        public async Task DeleteRestaurantMenuItem(int id, int itemId, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
        //TODO Add Update endpoints for restaurant and restaurant menuItems
    }
}
