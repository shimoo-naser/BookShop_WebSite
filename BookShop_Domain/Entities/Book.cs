﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Domain.Entities
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }


        public decimal Price { get; set; }


        public String Specialization { get; set; }

    }
}

