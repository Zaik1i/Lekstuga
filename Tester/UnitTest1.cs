using System;
using Xunit;

namespace Tester
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(expected:4, actual:4);
            Assert.NotEqual(expected: 4, actual: 5);
            
        }

        [Fact]
        public void Test2()
        {

         Assert.Equal(5,5);
         Assert.NotEqual(5, 6); 

        }

        [Fact]
        public void Test3()
        {
            bool containerForAboleanValue = true; 

            Assert.True(containerForAboleanValue);

            bool dreamcast = false;
            Assert.False(dreamcast);
        }

        [Fact]
        public void Rome()

        {
            string name = "Zaki";

            if (false)
            {
                name = "Mr james"; 
            }
            Assert.Equal("Zaki", name);

            string tokyo = "japan";
            Assert.Equal("japan", tokyo); 

            Assert.Equal(5, 2+3);

            

        }




    }
}
