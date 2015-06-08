using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Control_v2.IO
{
    [ProtoContract]
    struct AutomationProcess
    {
        [ProtoMember(1)]
        public string ProcessName;
        [ProtoMember(2)]
        public string SchemeGuid;
        [ProtoMember(3)]
        public int Priority;
    }
}
