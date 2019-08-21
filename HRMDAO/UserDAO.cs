using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMEFentity.Entity;//需要用到HRMEFentity 里的 EO
using HRMModel;
using IHRMDAO;
namespace HRMDAO
{
    public class UserDAO : DaoBase<User>, IUserDAO
    {
        public List<UserModel> SelectByx(UserModel muser)
        {
            List<User> list = SelectByx(e => e.u_name.Equals(muser.u_name) && e.u_password.Equals(muser.u_password));
            List<UserModel> list2 = new List<UserModel>();

            foreach (User item in list)
            {
                UserModel um = new UserModel()
                {
                    Id = item.Id,
                    u_name = item.u_name,
                    u_password = item.u_password,
                    u_true_name = item.u_true_name
                };
                list2.Add(um);
            }
            return list2;
        }
    }
}
