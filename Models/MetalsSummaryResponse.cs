using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nfusionsolutionsChallengeAPI.Models
{
    public class MetalsSummaryResponse
    {
        public string requestedSymbol { get; set; }
        public string requestedCurrency { get; set; }
        public string requestedUnitOfMeasure { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
        public MetalsData data { get; set; }
    }
}
