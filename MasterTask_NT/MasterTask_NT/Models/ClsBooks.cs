using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MasterTask_NT.Models
{
    public class ClsBooks
    {
        [Key]
        public int ID { get; set; }

        public string ISBN { get; set; }

        public string Name { get; set; }

        
    }
}