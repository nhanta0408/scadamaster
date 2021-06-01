using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    public class Historian
    {
        public SCADA Parent = null;
        public string Name;
        public RingBuffer ringBuffer;
        public Historian(string name, int numberOfData)
        {
            Name = name;
            ringBuffer = new RingBuffer(numberOfData);
        }
        public void AddData(dynamic data)
        {
            ringBuffer.Enqueue(data);
        }
    }
}
