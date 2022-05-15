namespace ev30
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class RPinvokeMarshalling
    {
        
        public RPinvokeMarshalling()
        {
        }

        [Benchmark]
        public void Baseline()
        {
            int spinCount = 10000;
            int sum = 0;
            for (int index = 0; index < spinCount; ++index)
            {
                ReturnValue marshalledValue = TypePassing.GetReturnType();

                if (marshalledValue.Level > 100)
                {
                    Console.WriteLine("Unreached.");
                }
                else
                {
                    sum += marshalledValue.Level;
                }
            }
        }

        [Benchmark]
        public void WithSpan()
        {
            Span<char> version = stackalloc char[256];
            Span<char> processId = stackalloc char[256];
            Span<char> processName = stackalloc char[256];
            Span<char> objectId = stackalloc char[256];
            int level = 0;
            Span<char> data = stackalloc char[256];
            Span<char> dataHash = stackalloc char[256];
            Span<char> dataAlgorithm = stackalloc char[256];
            Span<char> dataIdentifier = stackalloc char[256];
            Span<char> dataIdentifiers = stackalloc char[256];
            Span<char> validDate = stackalloc char[256];
            Span<char> expirationDate = stackalloc char[256];
            Span<char> identity = stackalloc char[256];
            Span<char> parentIdentifier = stackalloc char[256];
            Span<char> parentStrongIdentifier = stackalloc char[256];
            Span<char> policy = stackalloc char[256];
            int result = 0;
            Span<char> reason = stackalloc char[256];
            Span<char> matchedData = stackalloc char[256];
            Span<char> matchedParentData = stackalloc char[256];
            Span<char> matchedParentIdentifier = stackalloc char[256];

            int spinCount = 10000;
            int sum = 0;
            for (int index = 0; index < spinCount; ++index)
            {
                int versionCount = 0;
                int processIdCount = 0;
                int processNameCount = 0;
                int objectIdCount = 0;
                int dataCount = 0;
                int dataHashCount = 0;
                int dataAlgorithmCount = 0;
                int dataIdentifierCount = 0;
                int dataIdentifiersCount = 0;
                int validDateCount = 0;
                int expirationDateCount = 0;
                int identityCount = 0;
                int parentIdentifierCount = 0;
                int parentIdentifiersCount = 0;
                int parentStrongIdentifierCount = 0;
                int policyCount = 0;
                int reasonCount = 0;
                int matchedDataCount = 0;
                int matchedParentDataCount = 0;
                int matchedParentIdentifierCount = 0;

                TypePassing.GitReturnType(MemoryMarshal.GetReference(version),
                                          ref versionCount,
                                          MemoryMarshal.GetReference(processId),
                                          ref processIdCount,
                                          MemoryMarshal.GetReference(processName),
                                          ref processNameCount,
                                          MemoryMarshal.GetReference(objectId),
                                          ref objectIdCount,
                                          ref level,
                                          MemoryMarshal.GetReference(data),
                                          ref dataCount,
                                          MemoryMarshal.GetReference(dataHash),
                                          ref dataHashCount,
                                          MemoryMarshal.GetReference(dataAlgorithm),
                                          ref dataAlgorithmCount,
                                          MemoryMarshal.GetReference(dataIdentifier),
                                          ref dataIdentifierCount,
                                          MemoryMarshal.GetReference(dataIdentifiers),
                                          ref dataIdentifiersCount,
                                          MemoryMarshal.GetReference(validDate),
                                          ref validDateCount,
                                          MemoryMarshal.GetReference(expirationDate),
                                          ref expirationDateCount,
                                          MemoryMarshal.GetReference(identity),
                                          ref identityCount,
                                          MemoryMarshal.GetReference(parentIdentifier),
                                          ref parentIdentifierCount,
                                          MemoryMarshal.GetReference(parentStrongIdentifier),
                                          ref parentIdentifierCount,
                                          MemoryMarshal.GetReference(policy),
                                          ref policyCount,
                                          ref result,
                                          MemoryMarshal.GetReference(reason),
                                          ref reasonCount,
                                          MemoryMarshal.GetReference(matchedData),
                                          ref matchedDataCount,
                                          MemoryMarshal.GetReference(matchedParentData),
                                          ref matchedDataCount,
                                          MemoryMarshal.GetReference(matchedParentIdentifier),
                                          ref matchedParentIdentifierCount);

                if (level > 100)
                {
                    Console.WriteLine("Unreached.");
                }
                else
                {
                    sum += level;
                }
            }
        }

    }
}