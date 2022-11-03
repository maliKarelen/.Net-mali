using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULS
{
    public class Email
    {
        public string Subject { get; set; }
        public contacts Sender { get; set; }

        public int IdEmail { get; set; }
        public List<contacts> Recive { get; set; }

        public override string ToString()
        {
            return $"{nameof(Sender)}:{Sender},{nameof(Subject)}:{Subject}";
        }
    }
}
