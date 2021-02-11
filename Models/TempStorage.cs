using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment4.Models
{
    public static class TempStorage
    {
        private static List<UserRecommendation> recommendations = new List<UserRecommendation>();

        public static IEnumerable<UserRecommendation> Recommendations => recommendations;

        public static void AddRecommendation(UserRecommendation recommendation)
        {
            recommendations.Add(recommendation);
        }

    }

}
