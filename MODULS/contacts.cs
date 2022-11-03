using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULS
{
    public class contacts
    {
        public string name{ get; set; }
        public string email{ get; set; }
        public int IdContact { get; set; }
        public object IdEmail { get; set; }

        public override string ToString()
        {
            return $"{nameof(name)}:{name},{nameof(email)}:{email}";
        }
    }
}
