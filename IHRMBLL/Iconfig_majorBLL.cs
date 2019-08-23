using HRMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRMBLL
{
   public interface Iconfig_majorBLL
    {
        List<config_majorModel> QueALL();
        int Delete(config_majorModel m);
        int Add(config_majorModel m);

    }
}
