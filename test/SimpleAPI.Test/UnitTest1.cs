using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get(1);
            //Assert.Equal("gmg", returnValue.Value);
            Assert.Equal("gmg value", returnValue.Value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
