//  --------------------------------------------------------------------------------------
// PostSharp.Example.Lib.CallChainAccumulator.cs
// 2017/11/16
//  --------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace PostSharp.Example.Lib.Interceptor
{
    // Simple helper class for accumulating call chains during testing.
    public static class CallChainAccumulator
    {
        static readonly IList<string> InvocationList = new List<string>();

        public static void Clear()
        {
            InvocationList.Clear();
        }

        public static string GetInvocationLog()
        {
            return string.Join(".", InvocationList);
        }

        public static void LogInvocation(string methodName)
        {
            InvocationList.Add(methodName);
        }
    }
}