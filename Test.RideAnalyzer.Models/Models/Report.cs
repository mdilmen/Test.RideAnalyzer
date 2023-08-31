
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.RideAnalyzer.Models.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RideCount { get; set; }
        public float RideTime { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal AmbulanceAmount { get; set; } = 0;
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal OverallAmount { get; set; } = 0;

        public int AccidentCount { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<RideReport> RideReports { get; set; } = new List<RideReport>();
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

    }
}
