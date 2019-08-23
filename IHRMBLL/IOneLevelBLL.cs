using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMBLL
{
  public interface IOneLevelBLL
    {

        int Add(OneLevelModel c);
        int Update(OneLevelModel c);
        int Delete(OneLevelModel c);
        List<OneLevelModel> QueryAll();

        List<OneLevelModel> SeleteBys(OneLevelModel om);
        List<OneLevelModel> SeleteByx(OneLevelModel om);
    }
}
