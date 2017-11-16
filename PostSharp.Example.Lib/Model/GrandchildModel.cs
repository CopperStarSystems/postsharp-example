//  --------------------------------------------------------------------------------------
// PostSharp.Example.Lib.GrandchildModel.cs
// 2017/11/15
//  --------------------------------------------------------------------------------------

using PostSharp.Example.Lib.Interceptor;

namespace PostSharp.Example.Lib.Model
{
    [CallChainAccumulatorAspect]
    public class GrandchildModel
    {
        public GrandchildModel()
        {
            SomeProperty = "Some Property Value";
        }

        public string SomeProperty { get; set; }
    }
}