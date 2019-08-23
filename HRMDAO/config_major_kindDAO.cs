using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
using HRMEFentity.Entity;
using IHRMDAO;

namespace HRMDAO
{
    public class config_major_kindDAO : DaoBase<config_major_kind>, Iconfig_major_kindDAO
    {
        public int Add(config_major_kindModel c)
        {
            config_major_kind est = new config_major_kind()
            {
                Id = c.Id,
                major_kind_id = c.major_kind_id,
                major_kind_name=c.major_kind_name
            };
            return Add(est);
        }

        public int Delete(config_major_kindModel c)
        {
            config_major_kind est = new config_major_kind()
            {
                Id = c.Id
            };
            return Delete(est);
        }


        /// <summary>
        /// 显示全部
        /// </summary>
        /// <returns></returns>
        List<config_major_kindModel> Iconfig_major_kindDAO.QueryAll()
        {
            List<config_major_kind> list = QueryAll();
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel ck = new config_major_kindModel() {
                    Id = item.Id,
                    major_kind_id=item.major_kind_id,
                    major_kind_name=item.major_kind_name
                };
                list2.Add(ck);
            }
            return list2;
        }
    }
}
