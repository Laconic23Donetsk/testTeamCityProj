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
        [Test]
        public void Foo_WhenCalled_ShouldPass()
        {
            //Arrange
            int a = 5;
            int b = 3;
            Class1 cl = new Class1();

            //Act
            var actual = cl.Foo(a, b);

            //Assert
            Assert.AreEqual(8, actual);
        }
    }
}
