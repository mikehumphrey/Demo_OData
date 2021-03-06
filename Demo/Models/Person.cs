﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Person
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Trip> Trips { get; set; }
    }
}