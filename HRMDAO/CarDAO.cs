using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMEFentity.Entity;//需要用到HRMEFentity 里的 EO
using HRMModel;
using IHRMDAO;
namespace HRMDAO
{
    public class CarDAO : DaoBase<Car>, ICarDAO
    {
        public int Add(CarModel c)
        {
            //把DTO转为EO
            Car est = new Car()
            {
                Id = c.Id,
                CName = c.CName
            };
            return Add(est);
        }

        public int Delete(CarModel c)
        {
            Car est = new Car()
            {
                Id = c.Id
            };
            return Delete(est);
        }

        public int Update(CarModel c)
        {
            Car est = new Car()
            {
                Id = c.Id,
                CName = c.CName
            };
            return Update(est);
        }

        List<CarModel> ICarDAO.QueryAll()
        {
            List<Car> list = QueryAll();
            List<CarModel> list2 = new List<CarModel>();
            foreach (Car item in list)
            {
                CarModel sm = new CarModel()
                {
                    Id = item.Id,
                    CName = item.CName
                };
                list2.Add(sm);
            }
            return list2;
        }
    }
}
