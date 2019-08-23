using HRMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRMBLL
{
   public interface Iconfig_public_charBLL
    {
        List<config_public_charModel> QueryAll();
        int Delete(config_public_charModel c);
    }
}
