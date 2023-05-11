using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.models;

namespace Dto
{
    public class PatientDto
    {
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters."), Required(ErrorMessage = "first name is Required")]
        public String firstName { get; set; }
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters."), Required(ErrorMessage = "last name is Required")]
        public String lastName { get; set; }

        [StringLength(9, MinimumLength = 9),Required(ErrorMessage = "tz is Required")]
        public String tz { get; set; }
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters."), Required(ErrorMessage = "city is Required")]
        public String city { get; set; }
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters."), Required(ErrorMessage = "street is Required")]
        public String street { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "The {0} field must only contain numbers."), Required(ErrorMessage = "birthDate is Required")]
        public int numStreet { get; set; }
        [DataType(DataType.Date) ,Required(ErrorMessage = "birthDate is Required")]
        public DateTime birthDate { get; set; }
        [Phone]
        public string phone { get; set; }
        [Phone,Required(ErrorMessage = "phoneNumber is Required")]
        public string phoneNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateRecovery { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime datePositiveResult { get; set; }


    }
}
