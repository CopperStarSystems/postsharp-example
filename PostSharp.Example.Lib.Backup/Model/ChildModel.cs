//  --------------------------------------------------------------------------------------
// PostSharp.Example.Lib.ChildModel.cs
// 2017/11/15
//  --------------------------------------------------------------------------------------

namespace PostSharp.Example.Lib.Model
{
    public class ChildModel
    {
        public ChildModel()
        {
            GrandchildModel=new GrandchildModel();
        }
        public GrandchildModel GrandchildModel { get; set; }
    }
}