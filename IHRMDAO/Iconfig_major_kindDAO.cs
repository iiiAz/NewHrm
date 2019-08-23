using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMDAO
{
   public interface Iconfig_major_kindDAO
    {
        List<config_major_kindModel> QueryAll();
        int Add(config_major_kindModel c);
        int Delete(config_major_kindModel c);
    }
}
