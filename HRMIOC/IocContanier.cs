using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using IHRMDAO;
using HRMDAO;
using IHRMBLL;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
namespace HRMIOC
{
    public class IocContanier
    {
        private static UnityContainer CreatIoc(string XmlName)
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecfm = new ExeConfigurationFileMap();
            ecfm.ExeConfigFilename = @"F:\克隆文件\HRMUI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecfm, ConfigurationUserLevel.None);
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, XmlName);
            return ioc;
        }

        /*****/
        public static ICarDAO CreateCar_DAO()
        {
            UnityContainer ioc = CreatIoc("confDAL");
            return ioc.Resolve<CarDAO>("CarDAO");
        }
        public static ICarBLL CreateCar_BLL()
        {
            UnityContainer ioc = CreatIoc("confBLL");
            return ioc.Resolve<ICarBLL>("CarBLL");
        }


        /*****/
        public static IUserDAO CreateUser_DAO()
        {
            UnityContainer ioc = CreatIoc("confDAL");
            return ioc.Resolve<UserDAO>("UserDAO");
        }
        public static IUserBLL CreateUser_BLL()
        {
            UnityContainer ioc = CreatIoc("confBLL");
            return ioc.Resolve<IUserBLL>("UserBLL");
        }


        public static Iconfig_major_kindDAO Createconfig_major_kind_DAO()
        {
            UnityContainer ioc = CreatIoc("confDAL");
            return ioc.Resolve<config_major_kindDAO>("config_major_kindDAO");
        }
        public static Iconfig_major_kindBLL Createconfig_major_kind_BLL()
        {
            UnityContainer ioc = CreatIoc("confBLL");
            return ioc.Resolve<Iconfig_major_kindBLL>("config_major_kindBLL");
        }


        public static Iconfig_public_charDAO Createconfig_public_charDAO()
        {
            UnityContainer ioc = CreatIoc("confDAL");
            return ioc.Resolve<config_public_charDAO>("config_public_charDAO");
        }
        public static Iconfig_public_charBLL CreateIconfig_public_charBLL()
        {
            UnityContainer ioc = CreatIoc("confBLL");
            return ioc.Resolve<Iconfig_public_charBLL>("config_public_charBLL");
        }


        public static Iconfig_majorDAO Createconfig_majorDAO()
        {
            UnityContainer ioc = CreatIoc("confDAL");
            return ioc.Resolve<config_majorDAO>("config_majorDAO");
        }
        public static Iconfig_majorBLL Createconfig_majorBLL()
        {
            UnityContainer ioc = CreatIoc("confBLL");
            return ioc.Resolve<Iconfig_majorBLL>("config_majorBLL");
        }
    }
}
