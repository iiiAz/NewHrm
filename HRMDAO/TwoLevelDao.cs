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
    public class TwoLevelDao :DaoBase<TwoLevel>,ITwoLevelDao
    {
        public int Add(TwoLevelModel c)
        {
            TwoLevel oe = new TwoLevel()
            {
            Id=c.Id,
            first_kind_id = c.first_kind_id,
            first_kind_name=c.first_kind_name,
           second_kind_id=c.second_kind_id,
           second_kind_name=c.second_kind_name,
           second_salary_id=c.second_salary_id,
           second_sale_id=c.second_sale_id
            };
            return Add(oe);

        }

        public int Delete(TwoLevelModel c)
        {
            TwoLevel oe = new TwoLevel()
            {
                Id = c.Id
            };
            return Delete(oe);
        }

        List<TwoLevelModel> ITwoLevelDao.QueryAll()
        {
            List<TwoLevel> list = QueryAll();
            List<TwoLevelModel> list2 = new List<TwoLevelModel>();
            foreach (TwoLevel item in list)
            {
                TwoLevelModel om = new TwoLevelModel()
                {
                   Id=item.Id,
                   first_kind_id=item.first_kind_id,
                   first_kind_name= item.first_kind_name,
                   second_kind_id= item.second_kind_id,
                   second_kind_name= item.second_kind_name,
                    second_salary_id= item.second_salary_id,
                    second_sale_id= item.second_sale_id
                };
                list2.Add(om);
            }
            return list2;
        }

        public List<TwoLevelModel> SeleteBys(TwoLevelModel om)
        {
            List<TwoLevel> list = SelectByx(e => e.Id.Equals(om.Id));
            List<TwoLevelModel> list2 = new List<TwoLevelModel>();
            foreach (TwoLevel item in list)
            {
                TwoLevelModel oo = new TwoLevelModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    second_salary_id = item.second_salary_id,
                    second_sale_id = item.second_sale_id
                };
                list2.Add(oo);
            }
            return list2;
        }

        public int Update(TwoLevelModel c)
        {
            TwoLevel oe = new TwoLevel()
            {
                Id = c.Id,
                first_kind_id = c.first_kind_id,
                first_kind_name = c.first_kind_name,
                second_kind_id = c.second_kind_id,
                second_kind_name = c.second_kind_name,
                second_salary_id = c.second_salary_id,
                second_sale_id = c.second_sale_id
            };
            return Update(oe);
        }

        public List<TwoLevelModel> SeleteByx(TwoLevelModel om)
        {
            List<TwoLevel> list = SelectByx(e => e.second_kind_id.Equals(om.second_kind_id));
            List<TwoLevelModel> list2 = new List<TwoLevelModel>();
            foreach (TwoLevel item in list)
            {
                TwoLevelModel oo = new TwoLevelModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    second_salary_id = item.second_salary_id,
                    second_sale_id = item.second_sale_id
                };
                list2.Add(oo);
            }
            return list2;
        }
    }
}
