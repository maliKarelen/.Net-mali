using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public static class Utilities
    {
        public static EmailBll ConfigEmailDependencies(string data)
        {
            switch (data)
            {
                case "Mock": DAL.MockDataSorce mock = new DAL.MockDataSorce();
                        return new EmailBll(mock);
                default:return new EmailBll(new DAL.SOL());
                       
            }
        }
    }
}
