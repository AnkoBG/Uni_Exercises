using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13B
{
    class SortedArray
    {
        decimal[] container = new decimal[0];

        public void Add(decimal v)
        {
            if (container.Length == 0)
            {
                container = new decimal[1];
                container[0] = v;
                return;
            }

            else
            {
                decimal[] placeholder = new decimal[container.Length + 1];
                for (int i = 0; i < container.Length; i++)
                    placeholder[i] = container[i];

                container = placeholder;

                container[container.Length - 1] = v;
            }
        }

        public void BubbleSort()
        {
            int n = container.Length;
            int counter = 0;
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for(int i = 0; i < n-1; i++)
                {
                    if(container[i] > container[i + 1])
                    {
                        var temp = container[i];
                        container[i] = container[i + 1];
                        container[i + 1] = temp;

                        sorted = false;
                    }
                }
                --n;
                counter++;
                if (counter == container.Length - 1)
                    return;
            }
        }
        public override string ToString()
        {
            string result = "[";

            foreach (var elem in container)
                result += elem.ToString() + ": ";

            result += "]";

            return result;
        }
    }
}
