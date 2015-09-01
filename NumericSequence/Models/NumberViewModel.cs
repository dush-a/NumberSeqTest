using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumericSequence.Models
{
    public class NumberViewModel
    {
        [Required]
        [Display(Name = "Enter an integer")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Must be a positive number 1 or higher")]
        [DefaultValue(10)]
        public int InputNumber { get; set; }

        [Display(Name = "All Numbers")]
        public string All { get; set; }

        [Display(Name = "Odd Sequence")]
        public string OddSequence { get; set; }

        [Display(Name = "Even Sequence")]
        public string EvenSequence { get; set; }

        [Display(Name = "Customised Sequence")]
        public string CustomisedSequence { get; set; }

        [Display(Name = "Fibonacci Sequence")]
        public string FibonacciSequence { get; set; }


    }
}