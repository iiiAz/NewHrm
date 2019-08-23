using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
using IHRMBLL;
using HRMIOC;
using IHRMDAO;
namespace HRMBLL
{
    public class config_majorBLL : Iconfig_majorBLL
    {
        Iconfig_majorDAO ioc = IocContanier.Createconfig_majorDAO();

        public int Add(config_majorModel m)
        {
            return ioc.Add(m);
        }

        public int Delete(config_majorModel m)
        {
          return  ioc.Delete(m);
        }

        public List<config_majorModel> QueALL()
        {
            return ioc.QueALL();
        }
    }
}
