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
    public class OneLevelBLL : IOneLevelBLL
    {

        IOneLevelDao od = IocContanier.CreateOneLevelDao();

        public int Add(OneLevelModel c)
        {
            return od.Add(c);
        }

        public int Delete(OneLevelModel c)
        {
            return od.Delete(c);
        }

        public List<OneLevelModel> QueryAll()
        {
            return od.QueryAll();
        }

        public List<OneLevelModel> SeleteBys(OneLevelModel om)
        {
            return od.SeleteBys(om);
        }

        public List<OneLevelModel> SeleteByx(OneLevelModel om)
        {
            return od.SeleteByx(om);
        }

        public int Update(OneLevelModel c)
        {
            return od.Update(c);
        }
    }
}
