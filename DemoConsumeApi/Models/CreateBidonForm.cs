using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoConsumeApi.Models
{
    public class CreateBidonForm
    {
        [Required]
        [MinLength(3)]
        [RegularExpression("^[a-zA-Z]*$")]
        public string Value { get; set; }
    }
}