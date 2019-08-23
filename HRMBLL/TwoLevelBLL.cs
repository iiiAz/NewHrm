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
    public class TwoLevelBLL : ITwoLevelBLL
    {
        ITwoLevelDao td = IocContanier.CreateTwoLevelDao();
        public int AddTwoLevel(TwoLevelModel c)
        {
            return td.Add(c);
        }

        public int DeleteTwoLevel(TwoLevelModel c)
        {
            return td.Delete(c);
        }

        public List<TwoLevelModel> QueryTwoLevelAll()
        {
            return td.QueryAll();
        }

        public List<TwoLevelModel> SeleteByx(TwoLevelModel om)
        {
            return td.SeleteByx(om);
        }

        public List<TwoLevelModel> SeleteTwoLevelBys(TwoLevelModel om)
        {
            return td.SeleteBys(om);
        }

        public int UpdateTwoLevel(TwoLevelModel c)
        {
            return td.Update(c);
        }
    }
}
