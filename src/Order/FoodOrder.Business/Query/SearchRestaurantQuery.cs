using System.Collections.Generic;
using FoodOrder.Data.Dtos;
using MediatR;

namespace FoodOrder.Business.Query
{
    public class SearchRestaurantQuery: IRequest<ICollection<RestaurantMenuDto>>
    {
        public SearchRestaurantQuery(string keyWord, string location)
        {
            KeyWord = keyWord;
            Location = location;
        }

        public string KeyWord { get; }
        public string Location { get; }
    }
}
