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
    public class CarBLL : ICarBLL
    {
        ICarDAO icd = IocContanier.CreateCar_DAO();
        public int Add(CarModel c)
        {
            return icd.Add(c);
        }

        public int Delete(CarModel c)
        {
            return icd.Delete(c);
        }

    
        public List<CarModel> QueryAll()
        {
            return icd.QueryAll();
        }

        public int Update(CarModel c)
        {
            return icd.Update(c);
        }
    }
}
