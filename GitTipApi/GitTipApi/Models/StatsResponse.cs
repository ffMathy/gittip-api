using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTipApi.Models
{
    public class StatsResponse
    {
        public double AverageTip { get; set; }
        public double AverageTippees { get; set; }
        public double Escrow { get; set; }
    }
}
