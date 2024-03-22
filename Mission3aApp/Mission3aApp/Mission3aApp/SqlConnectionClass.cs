using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3aApp
{
    public static class SqlConnectionClass
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    }
}
