namespace ev30
{
    using System;
    public struct StructUsing : IDisposable
    {
        private int state;
        public StructUsing()
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