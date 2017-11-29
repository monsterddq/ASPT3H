using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    static class  Utility
    {
        public static string GenerateId(string prefix)
            => $"{prefix}-{DateTime.Now.Ticks}";
    }
}
