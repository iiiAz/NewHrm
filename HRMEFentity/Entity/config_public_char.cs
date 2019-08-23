using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMEFentity.Entity
{
   public class config_public_char
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "输入用户名")]
        public string attribute_kind { get; set; }
        [Required(ErrorMessage = "请输入密码")]
        public string attribute_name { get; set; }
    }
}
