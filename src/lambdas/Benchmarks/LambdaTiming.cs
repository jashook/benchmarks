namespace ev30
{
    #pragma warning disable CS0219
    using System;
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class LambdaTiming
    {
        
        public LambdaTiming()
        {
        }

        [Benchmark]
        public void Baseline()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value3 == 2 && value5 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;

                methodToCall();
            }
        }

        [Benchmark]
        public void ModifiedOnlyUseOne()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall();
            }
        }

        [Benchmark]
        public void ModifiedOnlyUseTwo()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value3 % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall();
            }
        }

        [Benchmark]
        public void ModifiedOnlyUseThree()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value3 % 2 == 0 && value3 == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall();
            }
        }

        [Benchmark]
        public void ModifiedOnlyUseFour()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value3 % 2 == 0 && value3 == 10 && value4 == 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall();
            }
        }

        [Benchmark]
        public void ModifiedOnlyUseFive()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value3 % 2 == 0 && value3 == 10 && value4 == 100 && value5 == 123)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall();
            }
        }

        [Benchmark]
        public void ModifiedUseAll()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value3 % 2 == 0 && value3 == 10 && value4 == 100 && value5 == 90 && value6 == 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall();
            }
        }

        [Benchmark]
        public void UnmodifiedOnlyUseOne()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall();
            }
        }

        [Benchmark]
        public void UnmodifiedOnlyUseTwo()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall();
            }
        }

        [Benchmark]
        public void UnmodifiedOnlyUseThree()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value2 && value3 == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall();
            }
        }

        [Benchmark]
        public void UnmodifiedOnlyUseFour()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value2 && value3 == 10 && value4 == 921)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall();
            }
        }

        [Benchmark]
        public void UnmodifiedOnlyUseFive()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value2 && value3 == 10 && value4 == 921 && value5 == 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall();
            }
        }

        [Benchmark]
        public void UnmodifiedUseAll()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = () =>
            {
                if (value1 && value2 && value3 == 10 && value4 == 921 && value5 == 12 && value6 == 233)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall();
            }
        }

        [Benchmark]
        public void StaticModifiedUseOne()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1) =>
            {
                if (value1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall(value1);
            }
        }

        [Benchmark]
        public void StaticModifiedOnlyUseTwo()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, int value3) =>
            {
                if (value1 && value3 % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall(value1, value3);
            }
        }

        [Benchmark]
        public void StaticModifiedOnlyUseThree()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2, int value3) =>
            {
                if (value1 && value3 % 2 == 0 && value3 == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall(value1, value2, value3);
            }
        }

        [Benchmark]
        public void StaticModifiedOnlyUseFour()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2, int value3, int value4) =>
            {
                if (value1 && value3 % 2 == 0 && value3 == 10 && value4 == 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall(value1, value2, value3, value4);
            }
        }

        [Benchmark]
        public void StaticModifiedOnlyUseFive()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2, int value3, int value4, long value5) =>
            {
                if (value1 && value3 % 2 == 0 && value3 == 10 && value4 == 100 && value5 == 123)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall(value1, value2, value3, value4, value5);
            }
        }

        [Benchmark]
        public void StaticModifiedUseAll()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2, int value3, int value4, long value5, long value6) =>
            {
                if (value1 && value3 % 2 == 0 && value3 == 10 && value4 == 100 && value5 == 90 && value6 == 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                value1 = !value1;
                value2 = !value2;
                value3 = index + 2;
                value4 = index + 1;
                value5 = index;
                value6 = index - 1;
                
                methodToCall(value1, value2, value3, value4, value5, value6);
            }
        }

        [Benchmark]
        public void StaticUnmodifiedOnlyUseOne()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1) =>
            {
                if (value1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall(value1);
            }
        }

        [Benchmark]
        public void StaticUnmodifiedOnlyUseTwo()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2) =>
            {
                if (value1 && value2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall(value1, value2);
            }
        }

        [Benchmark]
        public void StaticUnmodifiedOnlyUseThree()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2, int value3) =>
            {
                if (value1 && value2 && value3 == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall(value1, value2, value3);
            }
        }

        [Benchmark]
        public void StaticUnmodifiedOnlyUseFour()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2, int value3, int value4) =>
            {
                if (value1 && value2 && value3 == 10 && value4 == 921)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall(value1, value2, value3, value4);
            }
        }

        [Benchmark]
        public void StaticUnmodifiedOnlyUseFive()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2, int value3, int value4, long value5) =>
            {
                if (value1 && value2 && value3 == 10 && value4 == 921 && value5 == 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall(value1, value2, value3, value4, value5);
            }
        }

        [Benchmark]
        public void StaticUnmodifiedUseAll()
        {
            bool value1 = false;
            bool value2 = false;
            int value3 = 0;
            int value4 = 0;
            long value5 = 0;
            long value6 = 0;

            IntPtr ptrValue = IntPtr.Zero;

            var methodToCall = static (bool value1, bool value2, int value3, int value4, long value5, long value6) =>
            {
                if (value1 && value2 && value3 == 10 && value4 == 921 && value5 == 12 && value6 == 233)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall(value1, value2, value3, value4, value5, value6);
            }
        }

        [Benchmark]
        public void StaticValueTuple()
        {
            var item = (false, true);

            var methodToCall = static (ValueTuple<bool, bool> tup) =>
            {
                (bool first, bool second) = tup;
                
                if (first && second)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int index = 0; index < 1000000; ++index)
            {
                methodToCall(item);
            }
        }
    }
}