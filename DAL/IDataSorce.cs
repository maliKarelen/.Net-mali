using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODULS;
namespace DAL
{
    public interface IDataSorce
    {
        List<Email> GetAll();
    }
}
