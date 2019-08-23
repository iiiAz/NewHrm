using HRMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRMBLL
{
   public interface Iconfig_major_kindBLL
    {
        List<config_major_kindModel> QueryAll();
        int Add(config_major_kindModel c);
        int Delete(config_major_kindModel c);
    }
}
