using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODULS;

namespace BLL
{
    public class EmailBll
    {
        IDataSorce ds;//= new DAL.MockDataSource();
        public EmailBll(IDataSorce ds)
        {
            this.ds = ds;
        }

        public List<Email> GetAll()
        {
            var list = ds.GetAll();
            return list;
        }
    }
}
