using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LukasVanagas.Models
{
    public class Employee
    {
        [DisplayName("Empoyee ID")]
        [Required(ErrorMessage = "An employee must have an id")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Employee ID must a 2-digit number")]
        public string id { get; set ; }

        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "An employee must have a name")]
        public string firstName { get; set; }

        [DisplayName("Employee Surname")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "The surname must consist of 5 to 20 characters")]
        public string lastName { get; set; }


    }
}