using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11B
{
    class DynamicArray
    {
        byte[] container;

        public void AddRange(byte[] range, int count)
        {
            if(container == null)
            {
                container = new byte[count];
                for(int i = 0; i < count; i++)
                    container[i] = range[i];
            }
            else
            {
                if (count == 0)
                    return;
                byte[] placeholder = new byte[container.Length + count];
                for(int i = 0; i < container.Length; i++)
                    placeholder[i] = container[i];

                container = placeholder;

                for (int i = 0; i < count; i++)
                {
                        container[placeholder.Length + i - count] = range[i];
                }
            }
        }

        public byte[] ToArray()
        {
            return container;
        }
    }
}
