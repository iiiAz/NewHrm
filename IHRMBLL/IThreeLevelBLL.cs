﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
namespace IHRMBLL
{
   public interface IThreeLevelBLL
    {
        int Add(ThreeLevelModel c);
        int Update(ThreeLevelModel c);
        int Delete(ThreeLevelModel c);
        List<ThreeLevelModel> QueryAll();

        List<ThreeLevelModel> SeleteBys(ThreeLevelModel om);
    }
}
