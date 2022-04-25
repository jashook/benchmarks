namespace ev30
{
    using System;
    using System.Threading.Tasks;
    public struct AsyncClassUsing : IAsyncDisposable
    {
        private int state;
        public AsyncClassUsing()
        {
            state = 10;
        }

        public async ValueTask DisposeAsync()
        {
            await Task.Delay(0);
            if (state > 0)
            {
                state = -1;
            }
        }
    }
}