using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        H1_ERP.UI ui = new H1_ERP.UI();
        [Fact]
        public void Test1()
        {
            Assert.False(ui.Test("Hej"));
            Assert.False(ui.Test(" 15 2"));
            Assert.False(ui.Test(" "));
            Assert.True(ui.Test("425"));
            Assert.True(ui.Test("2104383"));
        }
    }
}
