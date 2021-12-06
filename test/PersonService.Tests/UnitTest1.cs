using System;
using Xunit;

namespace PersonService
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var t = new T();
            
            Assert.Equal(2, t.TT());
        }
    }
}
