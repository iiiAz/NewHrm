using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMIOC;
using IHRMDAO;
using HRMModel;
using IHRMBLL;
namespace HRMBLL
{
    public class UserBLL : IUserBLL
    {
        IUserDAO iud = IocContanier.CreateUser_DAO();
        public List<UserModel> SelectByx(UserModel muser)
        {
            return iud.SelectByx(muser);
        }
    }
}
