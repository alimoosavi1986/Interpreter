using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Context
    {
        public string Expression { get; set; }
        public DateTime Date { get; set; }
        public Context(DateTime date)
        {
            this.Date = date;
        }
    }
}
