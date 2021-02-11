using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment4.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            RestRank = rank;
        }
        
        public int? RestRank { get;} = 235;
        public string RestName { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";
        public string RestAddress { get; set; } = "--";
        public string RestPhone { get; set; } = "--";
        public string RestWeb { get; set; } = "Coming Soon";

        
        
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestName = "Bombay House", 
                FavDish = "Chicken Coconut Kurma",
                RestAddress = "Right by my house",
                RestPhone = "801-555-5555",
                RestWeb = "Webstie.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestName = "Five Sushi Brothers",
                FavDish = "Band Manager",
                RestAddress = "Also right by my house",
                RestPhone = "801-555-5556",
                RestWeb = "Webstie.com/sushi"
            };
            Restaurant r3 = new Restaurant(3)
            {
                RestName = "Cafe Zupas",
                FavDish = "Chicken Avocado Chop Salad",
                RestAddress = "Just off University Pkwy",
                RestPhone = "801-555-5557",
                RestWeb = "Webstie.com/Zupas"
            };
            Restaurant r4 = new Restaurant(4)
            {
                RestName = "Chip",
                FavDish = "OG Cooke",
                RestAddress = "Also right by my house",
                RestPhone = "801-555-5558",
                RestWeb = "Webstie.com/Chip"
            };
            Restaurant r5 = new Restaurant(5)
            {
                RestName = "Jimmy John's",
                FavDish = "#6 The Veggie",
                RestAddress = "Also just off University Pkwy",
                RestPhone = "801-555-5559",
                RestWeb = "Webstie.com/jimmyj"
            };



            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
