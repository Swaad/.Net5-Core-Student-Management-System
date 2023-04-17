using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLearning.Helper
{
    public class ApiResponse
    {
        public dynamic ApiData { get; set; }
        public string Message { get; set; }
        public bool IsExecuted { get; set; }
        public dynamic Data { get; set; }

    }
}
