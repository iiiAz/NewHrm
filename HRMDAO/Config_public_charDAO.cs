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
    public class Config_public_charDAO : DaoBase<config_public_char>, IConfig_public_charDAO
    {
        public int Add(config_public_charModel c)
        {
            //把DTO转为EO
            config_public_char cpc = new config_public_char()
            {
                attribute_kind = c.attribute_kind,
                attribute_name = c.attribute_name
            };
            return Add(cpc);
        }

        public int Delete(config_public_charModel c)
        {            
            //把DTO转为EO
            config_public_char cpc = new config_public_char()
            {
                Id = c.Id
            };
            return Delete(cpc);
        }

        public List<config_public_charModel> SelectByx(config_public_charModel cpc)
        {
            List<config_public_char> list = SelectByx(e => e.attribute_kind.Equals(cpc.attribute_kind));
            List<config_public_charModel> list2 = new List<config_public_charModel>();

            foreach (config_public_char item in list)
            {
                config_public_charModel cc = new config_public_charModel()
                {
                    Id = item.Id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name
                };
                list2.Add(cc);
            }
            return list2;
        }

        List<config_public_charModel> IConfig_public_charDAO.QueryAll()
        {
            List<config_public_char> list = QueryAll();
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel cpc = new config_public_charModel()
                {
                    Id = item.Id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name,
                };
                list2.Add(cpc);
            }
            return list2;
        }
    }
}
