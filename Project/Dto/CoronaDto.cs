using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CoronaDto

    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime vaccinationDate { get; set; }
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters.")]
        public string vaccineManufacturer { get; set; }

            
    }
}
