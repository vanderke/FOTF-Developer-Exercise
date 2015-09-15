using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadyToWed
{
    public class Maybe<T> : IEnumerable<T>
    {

        private readonly IEnumerable<T> list;

        public Maybe()
        {
            this.list = new T[0];
        }

        public Maybe(T value)
        {
            this.list = new[] { value };
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
