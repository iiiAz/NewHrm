using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HRMEFentity.Entity
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "输入用户名")]
        public string u_name { get; set; }
        [Required(ErrorMessage = "请输入密码")]
        public string u_password { get; set; }
        public string u_true_name { get; set; }

    }
}
