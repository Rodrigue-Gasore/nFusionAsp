using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nfusionsolutionsChallengeAPI.Models
{
    public class MetalsData
    {
        public string symbol { get; set; }
        public string baseCurrency { get; set; }
        public double? last { get; set; }
        public double? bid { get; set; }
        public double? ask { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
        public double? open { get; set; }
        public double? oneDayValue { get; set; }
        public double? oneDayChange { get; set; }
        public double? oneDayPercentChange { get; set; }
        public DateTime timeStamp { get; set; }
    }
}
