//  --------------------------------------------------------------------------------------
// PostSharp.Example.Lib.TraceWriterAttribute.cs
// 2017/11/15
//  --------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace PostSharp.Example.Lib.Interceptor
{
    [Serializable, PSerializable]
    public class TraceWriterAttribute : OnMethodBoundaryAspect
    {
        string category = "some category";
        public override void OnEntry(MethodExecutionArgs eventArgs)
        {
            Trace.WriteLine(
                string.Format("Entering {0}.{1}.",
                              eventArgs.Method.DeclaringType.Name,
                              eventArgs.Method.Name),
                this.category);
        }

        public override void OnExit(MethodExecutionArgs eventArgs)
        {
            Trace.WriteLine(
                string.Format("Leaving {0}.{1}.",
                              eventArgs.Method.DeclaringType.Name,
                              eventArgs.Method.Name),
                this.category);
        }
    }
}