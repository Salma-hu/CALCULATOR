using System;
using Xunit;
using Calculator;

namespace TestCaclulator
{
    public class UnitTest1
    {

        public unitCalcul clt = new unitCalcul ();

        [Fact]
        public void AddTest()
        {

            // Arrange

            

            var s = clt.Addition(1,2);
            
            
            //Assert

              
                Assert.Equal (3, s) ;


        }



        [Fact]
        public void SubTest()
        {

            // Arrange



            var s = clt.Subtraction(3, 2);


            //Assert


            Assert.Equal(2, s);


        }


        [Fact]
        public void MultpTest()
        {

            // Arrange



            var s = clt.Multiplication(3, 2);


            //Assert


            Assert.Equal(6, s);


        }



        [Fact]
        public void DivTest()
        {

            // Arrange



            var s = clt.Division(3, 2);


            //Assert


            Assert.Equal(1, s);


        }
    }
}
