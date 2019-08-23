using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMDAO
{
    public interface IConfig_public_charDAO
    {
        List<config_public_charModel> QueryAll();
        int Add(config_public_charModel c);
        int Delete(config_public_charModel c);
        List<config_public_charModel> SelectByx(config_public_charModel cpc);
    }
}
