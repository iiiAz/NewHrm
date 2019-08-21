using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMDAO
{
    public interface ICarDAO
    {
        int Add(CarModel c);
        int Update(CarModel c);
        int Delete(CarModel c);
        List<CarModel> QueryAll();
    }
}
