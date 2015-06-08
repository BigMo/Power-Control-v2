using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Control_v2.PowerCfg
{
    public struct Scheme
    {
        public string Name;
        public string Guid;

        public Scheme(string name, string guid)
        {
            this.Name = name;
            this.Guid = guid;
        }
    }
}
