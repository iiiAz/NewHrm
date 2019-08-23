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
    public class ThreeLevelBLL : IThreeLevelBLL
    {

        IThreeLevelDao td = IocContanier.CreateThreeLevelDao();
        public int Add(ThreeLevelModel c)
        {
            return td.Add(c);
        }

        public int Delete(ThreeLevelModel c)
        {
            return td.Delete(c);
        }

        public List<ThreeLevelModel> QueryAll()
        {
        return    td.QueryAll();
        }

        public List<ThreeLevelModel> SeleteBys(ThreeLevelModel om)
        {
            return td.SeleteBys(om);
        }

        public int Update(ThreeLevelModel c)
        {
            return td.Update(c);
        }
    }
}
