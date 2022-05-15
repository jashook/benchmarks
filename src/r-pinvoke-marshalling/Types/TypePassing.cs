namespace ev30
{
    using System;
    using System.Runtime.InteropServices;

    public static class TypePassing
    {
        [DllImport("TypeNativePassing", SetLastError=true)]
        public static extern ReturnValue GetReturnType();

        [DllImport("TypeNativePassing", SetLastError=true)]
        public static extern void GitReturnType(in char version,
                                                ref int versionCount,
                                                in char pid,
                                                ref int pidCount,
                                                in char processName,
                                                ref int processNameCount,
                                                in char objectId,
                                                ref int objectIdCount,
                                                ref int level,
                                                in char data,
                                                ref int dataCount,
                                                in char dataHash,
                                                ref int dataHashCount,
                                                in char dataAlgorithm,
                                                ref int dataAlgorithmCount,
                                                in char dataIdentifier,
                                                ref int dataIdentifierCount,
                                                in char dataIdentifiers,
                                                ref int dataIdentifiersCount,
                                                in char validDate,
                                                ref int validDateCount,
                                                in char expirationDate,
                                                ref int expirationDateCount,
                                                in char identity,
                                                ref int identityCount,
                                                in char parentIdentifier,
                                                ref int parentIdentifierCount,
                                                in char parentStrongIdentifier,
                                                ref int parentStrongIdentifierCount,
                                                in char policy,
                                                ref int policyCount,
                                                ref int result,
                                                in char reason,
                                                ref int reasonCount,
                                                in char matchedData,
                                                ref int matchedDataCount,
                                                in char matchedParentData,
                                                ref int matchedParentDataCount,
                                                in char matchedParentIdentifier,
                                                ref int matchedParentIdentifierCount);
    }
}