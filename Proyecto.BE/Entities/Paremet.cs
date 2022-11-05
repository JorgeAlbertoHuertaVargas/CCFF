﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCFF.Modelo.Entities
{
    public class Paremet
    {
        [Key]
        public int ParemetId { get; set; }
        public string ParemetName { get; set; }
        public bool Status { get; set; }
       
    }
}
