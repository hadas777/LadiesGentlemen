﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class Order
    {
        
        public int Id { get; set; }
        public Client Client { get; set; }
        public float Sum { get; set; }
        public Address Address { get; set; }
        public Cart Cart { get; set; }

    }
}