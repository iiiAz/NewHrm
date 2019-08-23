using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMEFentity.Entity
{
   public class ThreeLevel
    {
        //       ftk_id smallint identity not null,
        //   first_kind_id char(2) ,
        //first_kind_name varchar(60) ,
        //second_kind_id char(2) ,
        //second_kind_name varchar(60) ,
        //third_kind_id char(2) ,
        //third_kind_name varchar(60) ,
        //third_kind_sale_id text,
        //   third_kind_is_retail char(2) )  

        public int Id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }

        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public string third_kind_sale_id { get; set; }
        public string third_kind_is_retail { get; set; }
    }
}
