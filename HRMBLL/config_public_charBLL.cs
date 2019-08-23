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
    public class config_public_charBLL : Iconfig_public_charBLL
    {
        Iconfig_public_charDAO IOC = IocContanier.Createconfig_public_charDAO();
        public int Delete(config_public_charModel c)
        {
            return IOC.Delete(c) ;
        }

        public List<config_public_charModel> QueryAll()
        {
            return IOC.QueryAll();
        }
    }
}
