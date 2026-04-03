using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PG_29.Common
{
    class Config
    {
        public static string ConnectionConfig = "";
        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8, 0, 11));

    }
}
