using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DBfirst.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; } = null!;
        [DisplayName("Middle Name")]
        public string? MiddleName { get; set; }
        [DisplayName("Surname")]
        public string? Surname { get; set; } 
        [DisplayName("Address Line")] 
        public string? AddressLine { get; set; }
        [DisplayName("City")]
        public string? City { get; set; } 
        [DisplayName("Country")] 
        public string? Country { get; set; } = null!;
        [DisplayName("Date")]
        public DateTime? Date { get; set; } = null!;       
        [DisplayName("Deceased")]
        public bool Deceased { get; set; }
        [DisplayName("Gender")] 
        public string? Gender { get; set; } = null!; 
        
    }
}
