using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaCompanySales.Models
{
    public static class GlobalSettings
    {
        public static TeaCompanyEntities DB = new TeaCompanyEntities();
        public static User LoggedUser;
    }
}
