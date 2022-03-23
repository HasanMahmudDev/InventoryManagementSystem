﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Models
{
    public class Unit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(75)]
        public string Description { get; set; }
    }
}
