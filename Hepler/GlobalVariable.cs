﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProvidenceFundQuize.Hepler
{
    public class GlobalVariable
    {
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; } }
    }
}
