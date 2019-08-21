using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMBLL
{
    public interface IUserBLL
    {
        List<UserModel> SelectByx(UserModel muser);
    }
}
