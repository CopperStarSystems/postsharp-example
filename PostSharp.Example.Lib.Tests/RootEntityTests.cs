//  --------------------------------------------------------------------------------------
// PostSharp.Example.Lib.Tests.RootEntityTests.cs
// 2017/11/15
//  --------------------------------------------------------------------------------------

using System;
using NUnit.Framework;
using PostSharp.Example.Lib.Interceptor;
using PostSharp.Example.Lib.Model;

namespace PostSharp.Example.Lib.Tests
{
    [TestFixture]
    public class RootEntityTests
    {
        RootModel systemUnderTest;

        [SetUp]
        public void SetUp()
        {
            systemUnderTest = new RootModel();
        }

        [Test]
        public void SomeTest()
        {
            var result = systemUnderTest.ChildModel.GrandchildModel.SomeProperty;
            OutputCallChain();
            //var child = systemUnderTest.ChildModel;
            //OutputCallChain();
        }

        static void OutputCallChain()
        {
            Console.WriteLine(CallChainAccumulator.GetInvocationLog());
            CallChainAccumulator.Clear();
        }
    }
}