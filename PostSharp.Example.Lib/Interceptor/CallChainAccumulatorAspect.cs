//  --------------------------------------------------------------------------------------
// PostSharp.Example.Lib.CallChainAccumulatorAspect.cs
// 2017/11/15
//  --------------------------------------------------------------------------------------

using System;
using PostSharp.Aspects;
using PostSharp.Extensibility;

namespace PostSharp.Example.Lib.Interceptor
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct |
                    AttributeTargets.Interface,
        AllowMultiple = true)]
    [MulticastAttributeUsage(MulticastTargets.Method,
        AllowMultiple = true,
        AllowExternalAssemblies = true,
        PersistMetaData = false,
        TargetMemberAttributes = MulticastAttributes.NonAbstract)]
    public class CallChainAccumulatorAspect : MethodInterceptionAspect
    {
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            if (ShouldLogInvocation(args))
                LogInvocation(args);

            base.OnInvoke(args);
        }

        static string CleanUpMethodName(string rawMethodName)
        {
            return rawMethodName.Replace("set_", string.Empty).Replace("get_", string.Empty);
        }

        static void LogInvocation(MethodInterceptionArgs args)
        {
            var method = args.Method;
            var methodName = CleanUpMethodName(method.Name);
            CallChainAccumulator.LogInvocation(methodName);
        }

        static bool ShouldLogInvocation(MethodInterceptionArgs args)
        {
            return args.Method != null && !args.Method.Name.StartsWith("set_");
        }
    }
}