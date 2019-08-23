using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMIOC;
using HRMModel;
using IHRMDAO;
using IHRMBLL;
namespace HRMBLL
{
    public class config_major_kindBLL : Iconfig_major_kindBLL
    {
        Iconfig_major_kindDAO ioc = IocContanier.Createconfig_major_kind_DAO();
        public int Add(config_major_kindModel c)
        {
          return  ioc.Add(c);
        }

        public int Delete(config_major_kindModel c)
        {
            return ioc.Delete(c);
        }

        public List<config_major_kindModel> QueryAll()
        {
            return ioc.QueryAll();
        }
    }
}
