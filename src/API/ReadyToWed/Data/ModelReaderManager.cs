using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadyToWed.Data
{
    public sealed class ModelReaderManager
    {

        private static IModelReader current;
        public static IModelReader Current
        {
            get
            {
                return current;
            }
            set
            {
                current = value;
            }
        }

    }
}
