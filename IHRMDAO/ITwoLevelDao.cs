using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMDAO
{
  public interface ITwoLevelDao
    {
        int Add(TwoLevelModel c);
        int Update(TwoLevelModel c);
        int Delete(TwoLevelModel c);
        List<TwoLevelModel> QueryAll();
        List<TwoLevelModel> SeleteBys(TwoLevelModel om);
        List<TwoLevelModel> SeleteByx(TwoLevelModel om);


    }
}
