using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMBLL
{
   public interface ITwoLevelBLL
    {
        int AddTwoLevel(TwoLevelModel c);
        int UpdateTwoLevel(TwoLevelModel c);
        int DeleteTwoLevel(TwoLevelModel c);
        List<TwoLevelModel> QueryTwoLevelAll();
        List<TwoLevelModel> SeleteTwoLevelBys(TwoLevelModel om);

        List<TwoLevelModel> SeleteByx(TwoLevelModel om);
    }
}
