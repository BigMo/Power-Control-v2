using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Control_v2.IO
{
    [ProtoContract]
    struct SaveData
    {
        [ProtoMember(1)]
        public AutomationProcess[] Processes;
        [ProtoMember(2)]
        public int AutomationInterval;
        [ProtoMember(3)]
        public bool AutomationEnabled;

        public static SaveData FromBytes(byte[] data)
        {
            SaveData saveData;
            using(MemoryStream stream = new MemoryStream(data))
            {
                saveData = Serializer.Deserialize<SaveData>(stream);
            }
            return saveData;
        }

        public static byte[] ToBytes(SaveData saveData)
        {
            byte[] data;
            using (MemoryStream stream = new MemoryStream())
            {
                Serializer.Serialize(stream, saveData);
                data = stream.ToArray();
            }
            return data;
        }

        public byte[] ToBytes()
        {
            return ToBytes(this);
        }
    }
}
