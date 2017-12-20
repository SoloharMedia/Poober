using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Poober.Models
{
    public class Pooper
    {
        //PRIMARY KEY
        public int PooperID { get; set; }

        //PERSONAL INFORMATION
        [MaxLength(80)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(80)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        [MaxLength(180)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string PostalCode { get; set; }

        [MaxLength(80)]
        public string City { get; set; }

        [MaxLength(40)]
        public string Phone { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime JoinDate { get; set; }

        [DefaultValue("AC")]
        [MaxLength(2)]
        public string Status { get; set; }

        //DOG INFORMATION
        [MaxLength(10)]
        public int Dogs { get; set; }

        [MaxLength(280)]
        public string DogBreeds { get; set; }

        [MaxLength(280)]
        public string DogNames { get; set; }

        //YARD - SERVICE INFORMATION
        public decimal YardSize { get; set; }

        public string YardsToService { get; set; }

        public bool RequireAccess { get; set; }

        [MaxLength(1800)]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        //RELATIONSHIPS
        public List<Job> Jobs { get; set; }
        public List<FinishedJob> FinishedJobs { get; set; }
    }
}
