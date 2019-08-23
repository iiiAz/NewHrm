using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMEFentity.Entity;//需要用到HRMEFentity 里的 EO
using HRMModel;
using IHRMDAO;
using System.Data.SqlClient;
namespace HRMDAO
{
   public class ThreeLevelDao:DaoBase<ThreeLevel>,IThreeLevelDao
    {
        public int Add(ThreeLevelModel c)
        {
            ThreeLevel oe = new ThreeLevel()
            {
                Id = c.Id,
                first_kind_id = c.first_kind_id,
                first_kind_name = c.first_kind_name,
                second_kind_id = c.second_kind_id,
                second_kind_name = c.second_kind_name,
                third_kind_id = c.third_kind_id,
                third_kind_is_retail = c.third_kind_is_retail,
                third_kind_name = c.third_kind_name,
                third_kind_sale_id = c.third_kind_sale_id
            };
            return Add(oe);
        }

        public int Delete(ThreeLevelModel c)
        {
            ThreeLevel oe = new ThreeLevel()
            {
                Id = c.Id
            };
            return Delete(oe);
        }

        public List<ThreeLevelModel> SeleteBys(ThreeLevelModel om)
        {
            List<ThreeLevel> list = SelectByx(e => e.Id.Equals(om.Id));
            List<ThreeLevelModel> list2 = new List<ThreeLevelModel>();
            foreach (ThreeLevel item in list)
            {
                ThreeLevelModel oo = new ThreeLevelModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_sale_id = item.third_kind_sale_id,
                    third_kind_name = item.third_kind_name,
                    third_kind_is_retail = item.third_kind_is_retail
                };
                list2.Add(oo);
            }
            return list2;
        }

        public int Update(ThreeLevelModel c)
        {
            ThreeLevel oe = new ThreeLevel()
            {
                Id = c.Id,
                first_kind_id = c.first_kind_id,
                first_kind_name = c.first_kind_name,
                second_kind_id = c.second_kind_id,
                second_kind_name = c.second_kind_name,
                third_kind_id = c.third_kind_id,
                third_kind_is_retail = c.third_kind_is_retail,
                third_kind_name = c.third_kind_name,
                third_kind_sale_id = c.third_kind_sale_id
            };
            return Update(oe);
        }

        List<ThreeLevelModel> IThreeLevelDao.QueryAll()
        {
            List<ThreeLevel> list = QueryAll();
            List<ThreeLevelModel> list2 = new List<ThreeLevelModel>();
            foreach (ThreeLevel item in list)
            {
                ThreeLevelModel om = new ThreeLevelModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_sale_id = item.third_kind_sale_id,
                    third_kind_name = item.third_kind_name,
                    third_kind_is_retail = item.third_kind_is_retail
                };
                list2.Add(om);
            }
            return list2;
        }
    }
}
