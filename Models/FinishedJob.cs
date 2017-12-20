using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poober.Models
{
    public class FinishedJob
    {
        //PRIMARY KEY
        public int FinishedJobID { get; set; }

        public int TotalTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FinishDateTime { get; set; }

        //FOREIGN KEYS
        [ForeignKey("JobID")]
        public int JobID { get; set; }
    }
}
