using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
using IHRMDAO;
using HRMEFentity.Entity;
namespace HRMDAO
{
    public class config_majorDAO : DaoBase<config_major>, Iconfig_majorDAO
    {
        public int Add(config_majorModel m)
        {
            //把DTO转为EO
            config_major est = new config_major()
            {
                major_kind_id = m.major_kind_id,
                major_kind_name=m.major_kind_name,
                major_id=m.major_id,
                major_name=m.major_name,
                test_amount=m.test_amount
            };
            return Add(est);
        }

        public int Delete(config_majorModel m)
        {
            config_major cc = new config_major()
            {
                Id = m.Id
            };
            return Delete(cc);
        }

        public List<config_majorModel> QueALL()
        {
            List<config_major> list = QueryAll();
            List<config_majorModel> list2 = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel m = new config_majorModel() {
                    Id = item.Id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    test_amount=item.test_amount
                
                };
                list2.Add(m);
            }
            return list2;
        }
    }
}
