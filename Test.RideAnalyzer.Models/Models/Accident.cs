using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.RideAnalyzer.Models.Models
{
    public class Accident
    {
        public int Id { get; set; }
        public DateTime AccidentDate { get; set; }
        public string Info { get; set; } = String.Empty;
        public int BinBinRideId { get; set; }
        public string TCKN { get; set; } = String.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
    }
}
