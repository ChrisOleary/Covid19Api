using Covid19Api.Models;
using System;
using Xunit;
using Shouldly;

namespace Covid19Api.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var t1 = new ApiRootObject() { Global = new Global {NewConfirmed=5 } };



            t1.Global.NewConfirmed.ShouldBe(5);
        }
    }
}
