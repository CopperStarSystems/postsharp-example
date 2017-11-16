//  --------------------------------------------------------------------------------------
// PostSharp.Example.Lib.RootModel.cs
// 2017/11/15
//  --------------------------------------------------------------------------------------

using PostSharp.Example.Lib.Interceptor;

namespace PostSharp.Example.Lib.Model
{
    [TraceWriter]
    public class RootModel
    {
        public RootModel()
        {
            ChildModel = new ChildModel();
        }

        public ChildModel ChildModel { get; set; }
    }
}