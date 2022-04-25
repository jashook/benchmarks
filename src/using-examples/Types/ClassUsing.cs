namespace ev30
{
    using System;
    public struct ClassUsing : IDisposable
    {
        private int state;
        public ClassUsing()
        {
            state = 10;
        }

        public void Dispose()
        {
            if (state > 0)
            {
                state = -1;
            }
        }
    }
}