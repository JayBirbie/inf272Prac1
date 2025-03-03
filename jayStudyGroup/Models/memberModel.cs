using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jayStudyGroup.Models
{
	public class memberModel
	{
        [Display(Name = "STUDENT NUMBER")]
        public string stuNumber { get; set; }

        [Display(Name = "NAME")]
        public string fName { get; set; }

        [Display(Name = "SURNAME")]
        public string lName { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string email { get; set; }
    }
}