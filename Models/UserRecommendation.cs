using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment4.Models
{
    public class UserRecommendation
    {
        public string Name { get; set; }

        public string RestaurantName { get; set; }

        public string FavoriteDish { get; set; } = "It's all tasty!";
        public string RestaurantPhone { get; set; } = "Coming soon!";
    }
}
