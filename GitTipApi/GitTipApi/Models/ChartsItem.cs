using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GitTipApi.Models
{
    public class ChartsItem
    {
        public int ActiveUsers { get; set; }
        public double Charges { get; set; }
        public DateTime Date { get; set; }
        public double TotalGifts { get; set; }
        public int TotalUsers { get; set; }
        public double WeeklyGifts { get; set; }
        public double Withdrawals { get; set; }
    }
}
