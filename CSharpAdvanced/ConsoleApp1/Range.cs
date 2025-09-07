using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Range<T> where T : IComparable<T>
    {
        private readonly T MinimumValue;
        private readonly T MaximumValue;

        public Range(T minimumValue, T maximumValue)
        {
            if(minimumValue.CompareTo(maximumValue) > 0)
            {
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
            }
            this.MinimumValue = minimumValue;
            this.MaximumValue = maximumValue;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(MinimumValue) >= 0 && value.CompareTo(MaximumValue) <= 0;
        }
        public int Length()
        {
            dynamic min = MinimumValue;
            dynamic max = MaximumValue;
            return max - min;
        }
    }
}
