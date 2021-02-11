using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BarkerAssignment4.Models
{
    public class UserRecommendation
    {
        public string Name { get; set; }

        public string RestaurantName { get; set; }

        public string FavoriteDish { get; set; } = "It's all tasty!";

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "The phone number entered is not a valid phone number.")]
        [Phone]
        public string RestaurantPhone { get; set; } = "Coming soon!";
    }
}
