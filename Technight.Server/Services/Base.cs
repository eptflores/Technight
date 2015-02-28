using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technight.Server.DataObjects.Adapters;

namespace Technight.Server.Services
{
    public class Base
    {
        private static string ConnectionString = "Data Source=tcp:maawtlhk9z.database.windows.net,1433;Initial Catalog=sqldev;User ID=technight@maawtlhk9z;Password=chicagoSogetiUSA!@#";

        public CookBookDataContext DBConnection
        {
            get
            {
                return new CookBookDataContext(ConnectionString)
                {
                    CommandTimeout = 180
                };
            }
        
        }
    }
}
