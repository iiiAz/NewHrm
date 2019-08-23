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
    public class Config_public_charBLL : IConfig_public_charBLL
    {
        IConfig_public_charDAO icpd = IocContanier.CreateChar_DAO();

        public int Add(config_public_charModel c)
        {
            return icpd.Add(c);
        }

        public int Delete(config_public_charModel c)
        {
            return icpd.Delete(c);
        }

        public List<config_public_charModel> QueryAll()
        {
            return icpd.QueryAll();
        }

        public List<config_public_charModel> SelectByx(config_public_charModel cpc)
        {
            return icpd.SelectByx(cpc);
        }
    }
}
