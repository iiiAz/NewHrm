﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMEFentity.Entity
{
   public class TwoLevel
    {
        public int Id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }

        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public  string second_salary_id { get; set; }
        public  string second_sale_id { get; set; }

    }
}
