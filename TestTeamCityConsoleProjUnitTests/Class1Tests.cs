using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTeamCityConsoleProj;

namespace TestTeamCityConsoleProjUnitTests
{
    [TestFixture]
    public class Class1Tests
    {
        [TestCase(5, 3, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 2)]
        [TestCase(-15, 10, -5)]
        public void Foo_WhenCalled_ShouldPass(int a, int b, int expected)
        {
            //Arrange
            Class1 cl = new Class1();

            //Act
            var actual = cl.Foo(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
/* Test build */