using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterTask_NT.Models
{
    public class ClsUser
    {
        [Required(ErrorMessage = "Please Enter ID")]
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Pass")]
        public string Pass { get; set; }
        
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }
       


    }

}