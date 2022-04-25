namespace ev30
{
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class UsingTimings
    {
        public UsingTimings()
        {
            
        }

        [Benchmark]
        public void BaselineWithLoop()
        {
            int count = 10000; // 10,000
            int increment = 0;

            for (int index = 0; index < count; ++index)
            {
                ++increment;
                if (increment % 2 == 0)
                {
                    --increment;
                }
                else
                {
                    increment += 3;
                }
            }
        }

        [Benchmark]
        public void BaselineWithLoopAndTryFinally()
        {
            int state = 10;

            try
            {
                int count = 10000; // 10,000
                int increment = 0;

                for (int index = 0; index < count; ++index)
                {
                    ++increment;
                    if (increment % 2 == 0)
                    {
                        --increment;
                    }
                    else
                    {
                        increment += 3;
                    }
                }
            }
            finally
            {
                if (state > 0)
                {
                    state = -1;
                }
            }
        }

        [Benchmark]
        public void StructUsingWithLoop()
        {
            using StructUsing value = new StructUsing();
            
            int count = 10000; // 10,000
            int increment = 0;

            for (int index = 0; index < count; ++index)
            {
                ++increment;
                if (increment % 2 == 0)
                {
                    --increment;
                }
                else
                {
                    increment += 3;
                }
            }
        }

        [Benchmark]
        public void ClassUsingWithLoop()
        {
            using ClassUsing value = new ClassUsing();
            
            int count = 10000; // 10,000
            int increment = 0;

            for (int index = 0; index < count; ++index)
            {
                ++increment;
                if (increment % 2 == 0)
                {
                    --increment;
                }
                else
                {
                    increment += 3;
                }
            }
        }

        [Benchmark]
        public void StructUsingWithLoopExceptionThrown()
        {
            var helper = static () => {
                using StructUsing value = new StructUsing();
            
                int count = 10000; // 10,000
                int increment = 0;

                for (int index = 0; index < count; ++index)
                {
                    ++increment;
                    if (increment % 2 == 0)
                    {
                        --increment;
                    }
                    else
                    {
                        increment += 3;
                    }
                }

                
                throw new Exception();
            };
            

            try
            {
                helper();
            }
            catch (Exception)
            {

            }
        }

        [Benchmark]
        public void ClassUsingWithLoopExceptionThrown()
        {
            var helper = static () => {
                using ClassUsing value = new ClassUsing();
            
                int count = 10000; // 10,000
                int increment = 0;

                for (int index = 0; index < count; ++index)
                {
                    ++increment;
                    if (increment % 2 == 0)
                    {
                        --increment;
                    }
                    else
                    {
                        increment += 3;
                    }
                }

                
                throw new Exception();
            };
            

            try
            {
                helper();
            }
            catch (Exception)
            {
                
            }
        }

        [Benchmark]
        public void StructUsingWithLoopExceptionThrownNonStaticHelper()
        {
            var helper = () => {
                using StructUsing value = new StructUsing();
            
                int count = 10000; // 10,000
                int increment = 0;

                for (int index = 0; index < count; ++index)
                {
                    ++increment;
                    if (increment % 2 == 0)
                    {
                        --increment;
                    }
                    else
                    {
                        increment += 3;
                    }
                }

                
                throw new Exception();
            };
            

            try
            {
                helper();
            }
            catch (Exception)
            {

            }
        }

        [Benchmark]
        public void ClassUsingWithLoopExceptionThrownNonStaticHelper()
        {
            var helper = () => {
                using ClassUsing value = new ClassUsing();
            
                int count = 10000; // 10,000
                int increment = 0;

                for (int index = 0; index < count; ++index)
                {
                    ++increment;
                    if (increment % 2 == 0)
                    {
                        --increment;
                    }
                    else
                    {
                        increment += 3;
                    }
                }

                
                throw new Exception();
            };
            

            try
            {
                helper();
            }
            catch (Exception)
            {
                
            }
        }

        [Benchmark]
        public async Task AsyncStructUsingWithLoop()
        {
            await using AsyncStructUsing value = new AsyncStructUsing();
            
            int count = 10000; // 10,000
            int increment = 0;

            for (int index = 0; index < count; ++index)
            {
                ++increment;
                if (increment % 2 == 0)
                {
                    --increment;
                }
                else
                {
                    increment += 3;
                }
            }
        }

        [Benchmark]
        public async Task AsyncClassUsingWithLoop()
        {
            await using AsyncClassUsing value = new AsyncClassUsing();
            
            int count = 10000; // 10,000
            int increment = 0;

            for (int index = 0; index < count; ++index)
            {
                ++increment;
                if (increment % 2 == 0)
                {
                    --increment;
                }
                else
                {
                    increment += 3;
                }
            }
        }
    }
}