﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITask.Core.Core.Models
{
    public class CountryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CountryViewModel> Countries { get; set; }
    }
}
