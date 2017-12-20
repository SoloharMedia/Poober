using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poober.Models
{
    public class Job
    {
        //PRIMARY KEY
        public int JobID { get; set; }

        [MaxLength(600)]
        [DataType(DataType.MultilineText)]
        public string ScooperNotes { get; set; }

        [MaxLength(600)]
        [DataType(DataType.MultilineText)]
        public string PooperNotes { get; set; }

        //POOPER FILLS OUT DAY AND TIME THEY WISH SCOOPER TO SHOW UP
        [DataType(DataType.DateTime)]
        public DateTime StartDateTime { get; set; }

        //SCOOPER ENTERS THIS WHEN THEY FINISH THE JOB
        [DataType(DataType.DateTime)]
        public DateTime FinishDateTime { get; set; }

        public decimal Cost { get; set; }

        public decimal ScooperRating { get; set; }

        public decimal PooperRating { get; set; }

        [DefaultValue("AC")]
        [MaxLength(2)]
        public string Status { get; set; }

        //FOREIGN KEYS
        [ForeignKey("PooperID")]
        public int PooperID { get; set; }

        [ForeignKey("ScooperID")]
        public int ScooperID { get; set; }
    }
}
