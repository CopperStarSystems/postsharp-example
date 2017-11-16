//  --------------------------------------------------------------------------------------
// PostSharp.Example.Lib.ChildModel.cs
// 2017/11/15
//  --------------------------------------------------------------------------------------

using PostSharp.Example.Lib.Interceptor;

namespace PostSharp.Example.Lib.Model
{
    [CallChainAccumulatorAspect]
    public class ChildModel
    {
        public ChildModel()
        {
            GrandchildModel = new GrandchildModel();
        }
        public GrandchildModel GrandchildModel { get; set; }
    }
}