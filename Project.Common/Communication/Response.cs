using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Response
    {
        public string Message { get; set; }
        public bool Success { get; set; } = true;
        public object Object { get; set; }
        public int ErrorCode { get; set; }
    }
}
