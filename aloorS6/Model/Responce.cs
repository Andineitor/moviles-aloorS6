using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aloorS6.Model
{
    public class ApiResponse<T>
    {
        public List<string> Messages { get; set; }
        public T Data { get; set; }
        public string Alert { get; set; }
        public bool Status { get; set; }
    }
}
