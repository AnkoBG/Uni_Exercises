using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12B
{
    class SortedSet 
    {
        decimal[] container = new decimal[0];

        public int BinarySearch(decimal v)
        {
            var pos = LowerBound(v);
            if (pos >= 0 && pos < container.Length)
                if(v == pos)
                    return pos;
            return -1;
        }
        public int LowerBound(decimal v)
        {
            int start = 0;
            int end = container.Length;
            while(start < end)
            {
                int mid = start + (end - start) / 2;
                if (container[mid] == v)
                {
                    return mid;
                }
                if (container[mid] > v)
                    end = mid;
                else 
                    start = mid + 1;
            }
            return start;
        }
        public void Add(decimal v)
        {
            if (container.Length == 0)
            {
                container = new decimal[1];
                container[0] = v;
                return;
            }

            int pos = LowerBound(v);

            if(pos == container.Length || container[pos] != v)
            {
                decimal[] placeholder = new decimal[container.Length + 1];
                for (int i = 0; i < placeholder.Length; i++)
                {
                    if (i < pos) placeholder[i] = container[i];
                    if (i == pos) placeholder[i] = v;
                    if (i > pos) placeholder[i] = container[i - 1];
                }
                container = placeholder;
            }
        }
        public decimal[] ToArray()
        {
            return container;
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
