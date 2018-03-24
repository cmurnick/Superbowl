using NUnit.Framework;
using Superbowl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperbowlTests
{
    [TestFixture]
    public class SuperbowlDateTests
    {
        [Test]
        public void Entering_the_number_1_and_convert_To_Roman_Numerals()
        {
            //Arrange
            var  number = 1;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Ashley(number);

            //Assert
            Assert.AreEqual("I", result );

            
        }

        [Test]
        public void Entering_the_number_4_and_convert_To_Roman_Numerals()
        {
            //Arrange
            var number = 5;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Ashley(number);

            //Assert
            Assert.AreEqual("V", result);


        }

        [Test]
        public void Entering_the_number_9_and_convert_To_Roman_Numerals()
        {
            //Arrange
            var number = 9;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Ashley(number);

            //Assert
            Assert.AreEqual("IX", result);
        }

        [Test]
        public void Entering_the_number_big_and_convert_To_Roman_Numerals()
        {
            //Arrange
            int number = 500;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Ashley(number);

            //Assert
            Assert.AreEqual("D", result);
        }
    }

    
}
