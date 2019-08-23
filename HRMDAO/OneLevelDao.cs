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
    public class OneLevelDao : DaoBase<OneLevel>,IOneLevelDao
    {
        public int Add(OneLevelModel c)
        {
            OneLevel oe = new OneLevel()
            {
               Id=c.Id,
               first_kind_id=c.first_kind_id,
               first_kind_name=c.first_kind_name,
               first_kind_salary_id=c.first_kind_salary_id,
               first_kind_sale_id=c.first_kind_sale_id
            };
            return Add(oe);   
        }

        public int Delete(OneLevelModel c)
        {
            OneLevel oe = new OneLevel()
            {
                Id=c.Id
            };
            return Delete(oe);
        }

        List<OneLevelModel> IOneLevelDao.QueryAll()
        {
            List<OneLevel> list = QueryAll();
            List<OneLevelModel> list2 = new List<OneLevelModel>();
            foreach (OneLevel item in list)
            {
                OneLevelModel om = new OneLevelModel()
                {
                    Id=item.Id,
                    first_kind_id=item.first_kind_id,
                    first_kind_name=item.first_kind_name,
                    first_kind_salary_id=item.first_kind_salary_id,
                    first_kind_sale_id=item.first_kind_sale_id
                };
                list2.Add(om);
            }
            return list2;
        }

        public int Update(OneLevelModel c)
        {
            OneLevel oe = new OneLevel()
            {
                Id = c.Id,
                first_kind_id = c.first_kind_id,
                first_kind_name = c.first_kind_name,
                first_kind_salary_id = c.first_kind_salary_id,
                first_kind_sale_id = c.first_kind_sale_id
            };
            return Update(oe);
        }

        public List<OneLevelModel> SeleteBys(OneLevelModel om)
        {
            List<OneLevel> list = SelectByx(e => e.Id.Equals(om.Id));
            List<OneLevelModel> list2 = new List<OneLevelModel>();
            foreach (OneLevel item in list) {
                OneLevelModel oo = new OneLevelModel()
                {
                    Id=item.Id,
                    first_kind_name=item.first_kind_name,
                    first_kind_id=item.first_kind_id,
                    first_kind_salary_id=item.first_kind_salary_id,
                    first_kind_sale_id=item.first_kind_sale_id
                };
                list2.Add(oo);
            }
            return list2;
        }

        public List<OneLevelModel> SeleteByx(OneLevelModel om)
        {
            List<OneLevel> list = SelectByx(e => e.first_kind_id.Equals(om.first_kind_id));
            List<OneLevelModel> list2 = new List<OneLevelModel>();
            foreach (OneLevel item in list)
            {
                OneLevelModel oo = new OneLevelModel()
                {
                    Id = item.Id,
                    first_kind_name = item.first_kind_name,
                    first_kind_id = item.first_kind_id,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(oo);
            }
            return list2;
        }
    }
}
