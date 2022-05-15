using System.Runtime.InteropServices;

using BenchmarkDotNet.Running;
using ev30;

var summary = BenchmarkRunner.Run<RPinvokeMarshalling>();

// ReturnValue value = TypePassing.GetReturnType();

// Console.WriteLine(Marshal.PtrToStringAnsi(value.Data));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.DataAlgorithm));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.DataHash));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.DataIdentifier));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.DataIdentifiers));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.ExpirationDate));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.Identity));
// Console.WriteLine(value.Level);
// Console.WriteLine(Marshal.PtrToStringAnsi(value.MatchedData));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.MatchedParentData));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.ObjectId));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.ParentIdentifier));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.ParentStrongIdentifier));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.Pid));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.Policy));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.ProcessName));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.Reason));
// Console.WriteLine(value.Result);
// Console.WriteLine(Marshal.PtrToStringAnsi(value.ValidDate));
// Console.WriteLine(Marshal.PtrToStringAnsi(value.Version));