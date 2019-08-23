using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMEFentity.Entity
{
   public class config_major_kind
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "输入编号"), StringLength(2)]
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
    }
}
