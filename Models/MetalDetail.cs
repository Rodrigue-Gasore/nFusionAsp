using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nfusionsolutionsChallengeAPI.Models
{
    public class MetalDetail
    {
        public string metal { get; set; }
        public double bidDelta { get; set; }
        public double askDelta { get; set; }
        public double oneDayChange { get; set; }
        public double oneDayPercentChange { get; set; }
        public MetalDetail(){
            oneDayChange = 0;
            oneDayPercentChange = 0;
        }
    }
}
