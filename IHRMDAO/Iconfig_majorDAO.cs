using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMDAO
{
 public   interface Iconfig_majorDAO
    {
        List<config_majorModel> QueALL();
        int Delete(config_majorModel m);

        int Add(config_majorModel m);
    }
}
