using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitbit.API.Model.Body
{
    public class Body
    {
        public decimal bicep { get; set; }
        public decimal bmi { get; set; }
        public decimal calf { get; set; }
        public decimal chest { get; set; }
        public decimal fat { get; set; }
        public decimal forearm { get; set; }
        public decimal hips { get; set; }
        public decimal neck { get; set; }
        public decimal thigh { get; set; }
        public decimal waist { get; set; }
        public decimal weight { get; set; }
    }

    public class BodyWeight
    {
        public decimal bmi { get; set; }
        public decimal fat { get; set; }
        public decimal weight { get; set; }
        public DateTime date { get; set; }
        public int logId { get; set; }
    }

    public class BodyFat
    {
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public int logId { get; set; }
        public decimal fat { get; set; }
    }

    public class BodyWeightGoals
    {
        public DateTime startDate { get; set; }
        public decimal startWeight { get; set; }
        public decimal weight { get; set; }
    }

    public class BodyFatGoal
    {
        public decimal bodyFat { get; set; }
    }

    public class GetBodyMeasurementsResponse
    {
        public Body body { get; set; }
        public BodyWeightGoals goals { get; set; }
    }

    public class GetBodyWeightResponse
    {
        public List<BodyWeight> weight { get; set; }
    }

    public class GetBodyFatResponse
    {
        public List<BodyFat> fat { get; set; }
    }

    public class GetBodyWeightGoalResponse
    {
        public BodyWeightGoals goal { get; set; }
    }

    public class GetBodyFatGoalResponse
    {
        public BodyFatGoal goal { get; set; }
    }
}
