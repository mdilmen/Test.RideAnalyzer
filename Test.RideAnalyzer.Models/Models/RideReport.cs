using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.RideAnalyzer.Models.Models
{
    public class RideReport
    {
        public int Id { get; set; }
        public int RideId { get; set; }
        public string TCKN { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string FullName { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ScooterId { get; set; }
        public int BinBinRideId { get; set; }
        public int RideDuration { get; set; }
        public DateTime RideDate { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

    }
}
