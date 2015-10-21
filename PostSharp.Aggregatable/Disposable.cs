using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharp.Aggregatable
{
    public abstract class Disposable : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            if (!disposed)
            {
                Dispose(true);
                disposed = true;
            }
        }

        protected abstract void Dispose(bool dispose);
    }
}
