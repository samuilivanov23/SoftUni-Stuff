using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Frogs
{
    public class Lake : IEnumerable<int>
    {
        public List<int> numbers;

        public Lake(List<int> numbers)
        {
            this.numbers = numbers;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.numbers.Count; i += 2)
                yield return this.numbers[i];

            for (int i = this.numbers.Count - 1; i >= 0; i -= 2)
                yield return this.numbers[i];

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
