using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Object
{
    public class Response
    {
        public string Message { get; set; }
        public bool IsSuccessfull { get; set; }
        public string Value { get; set; }
    }
}
