﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string BuyerName { get; set; }
        public ICollection<Pencil> Pencils { get; set; }
    }
}
